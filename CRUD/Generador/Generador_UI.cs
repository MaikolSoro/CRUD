using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using CRUD.Librerias;
namespace CRUD
{
    public partial class Generador_UI : Form
	{

		private AES aes = new AES();
		private string estado_conexion;
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		public string tituloProcedimiento;
		public string funcion;
		public string valores;
		public int largo;
		public string tabla;
		private string[] bases;
		private DataTable dt = new DataTable();
		private string dbcnString;
		private string servidor;
		private string usuario;
		private string contrasenna;
		private string use;
		private string indicador;
		private int contador;
		private string id;
		public Generador_UI()
		{
			InitializeComponent();
		}

		private string[] basesDeDatosContrasenna(string instancia)
		{
			// Las bases de datos de SQL Server
			string[] basesSys = { "master", "model", "msdb", "tempdb" };
			// Usamos la seguridad integrada de Windows
			string sCnn = "Server=" + instancia + "; " + "database=master; integrated security=False; User=" + usuario + "; password=" + contrasenna;

			// La orden T-SQL para recuperar las bases de master
			string sel = "Select name FROM sysdatabases";
			try
			{
				SqlDataAdapter da = new SqlDataAdapter(sel, sCnn);
				da.Fill(dt);
				bases = new string[dt.Rows.Count];
				int k = -1;
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					string s = dt.Rows[i]["name"].ToString();
					// Solo asignar las bases que no son del sistema
					if (Array.IndexOf(basesSys, s) == -1)
					{
						k += 1;
						bases[k] = s;
					}
				}

				if (k == -1)
				{
					return null;
				}
				Array.Resize(ref bases, k + 1);
				return bases;
				estado_conexion = "CONECTADO";
			}
			catch (Exception ex)
			{
				estado_conexion = "NO CONECTADO";

			}
			return null;

		}

		private string[] basesDeDatos(string instancia)
		{
			// Las bases de datos de SQL Server
			string[] basesSys = { "master", "model", "msdb", "tempdb" };
			// Usamos la seguridad integrada de Windows
			string sCnn = "Server=" + instancia + "; " + "database=master; integrated security=yes";

			// La orden T-SQL para recuperar las bases de master
			string sel = "Select name FROM sysdatabases";
			try
			{
				SqlDataAdapter da = new SqlDataAdapter(sel, sCnn);
				da.Fill(dt);
				bases = new string[dt.Rows.Count];
				int k = -1;
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					string s = dt.Rows[i]["name"].ToString();
					// Solo asignar las bases que no son del sistema
					if (Array.IndexOf(basesSys, s) == -1)
					{
						k += 1;
						bases[k] = s;
					}
				}

				if (k == -1)
				{
					return null;
				}
				Array.Resize(ref bases, k + 1);
				return bases;
				estado_conexion = "CONECTADO";

			}
			catch (Exception ex)
			{
				estado_conexion = "NO CONECTADO";

			}
			return null;

		}
		public void ReadfromXMLinstancia()
		{

			try
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("ConnectionString.xml");
				XmlElement root = doc.DocumentElement;
				dbcnString = root.Attributes.Item(0).Value;
				servidor = (aes.Decrypt(dbcnString, Desencryptacion.appPwdUnique, int.Parse("256")));

			}
			catch (System.Security.Cryptography.CryptographicException ex)
			{


			}
		}

		public void ReadfromXMLusuario()
		{

			try
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("usuario.xml");
				XmlElement root = doc.DocumentElement;
				dbcnString = root.Attributes.Item(0).Value;
				usuario = (aes.Decrypt(dbcnString, Desencryptacion.appPwdUnique, int.Parse("256")));

			}
			catch (System.Security.Cryptography.CryptographicException ex)
			{


			}
		}

		public void ReadfromXMLcontrasenna()
		{

			try
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("contraseña.xml");
				XmlElement root = doc.DocumentElement;
				dbcnString = root.Attributes.Item(0).Value;
				contrasenna = (aes.Decrypt(dbcnString, Desencryptacion.appPwdUnique, int.Parse("256")));

			}
			catch (System.Security.Cryptography.CryptographicException ex)
			{


			}
		}
		/// <summary>
		/// Creo el PROC de Insertar en SQLSERVER
		/// </summary>
		public void InsertarSQLServer()
        {

			use = "USE" + txtbasededatos.Text + "\r" + "GO" + "\r";
			tituloProcedimiento = "CREATE PROC insertar_" + tabla;
			txtInsertarSQLServer.Text = use + tituloProcedimiento;
			foreach(DataGridViewRow row in datalistadoEstructura.Rows)
            {
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string tipo = Convert.ToString(row.Cells["Tipo"].Value);
				string longitud = Convert.ToString(row.Cells["Longitud"].Value);
				int enumeracion = Convert.ToInt32(row.Cells["enumeracion"].Value);

				string longitudNumericaEntera = Convert.ToString(row.Cells["column1"].Value);
				string longitudNumericaDecimal = Convert.ToString(row.Cells["column2"].Value);

				if(enumeracion > 1)
                {
					if(longitud == "-1")
                    {
						longitud = "MAX";
                    }
					string longitud_completa = "(" + longitud + ")";

                    if (string.IsNullOrEmpty(longitud))
                    {
						if(tipo == "numeric" || tipo == "decimal")
                        {
							string longitud_para_numericos = "(" + longitudNumericaEntera + "," + longitudNumericaDecimal + ")";
							parametros = "@" + parametros + "As" + tipo + longitud_para_numericos + ",";
                        }
						else
                        {
							parametros = "@" + parametros + "As" + tipo + ",";

						}
                    }
                    else if(!string.IsNullOrEmpty(longitud) && tipo != "image")
                    {
						parametros = "@" + parametros + "As" + tipo + longitud_completa +  ",";
					}
					else if (!string.IsNullOrEmpty(longitud) && tipo == "image")
                    {
						parametros = "@" + parametros + "As" + tipo + ",";
					}

					txtInsertarSQLServer.Text = txtInsertarSQLServer.Text + "\r" + parametros;
				}
            }
			largo = txtInsertarSQLServer.Text.Length;
			txtInsertarSQLServer.Text = txtInsertarSQLServer.Text.Substring(0, largo - 1);
			txtInsertarSQLServer.Text = txtInsertarSQLServer.Text + "\r" + "As" + "\r";


			if(EvitarRepeticionesSQLServer.Checked == true)
            {
                if (!string.IsNullOrEmpty(lblRepeticionesSQLServer2.Text))
                {
					string condicional = null;
					string elseSQL = null;
					string errorSQL = null;
					string condicional_completa = null;
					condicional = "\r" + lblRepeticionesSQLServer1.Text + lblRepeticionesSQLServer2.Text + ")" + "\r";
					errorSQL = "RAISERROR (" + "'" + txtErrorSQLServer.Text + "'" + ", 16,1)" + "\r";
					elseSQL = "Else" + "\r";
					condicional_completa = condicional + errorSQL + elseSQL;
					funcion = condicional_completa + "INSERT INTO " + tabla + "\r";
				}
                else
                {
					MessageBox.Show("Ingrese los parámetros a validar");
                }
            }
            else
            {
				funcion = "INSERT INTO" + tabla + "\r";
            }
			txtInsertarSQLServer.Text = txtInsertarSQLServer.Text + funcion;
			txtInsertarSQLServer.Text = txtInsertarSQLServer.Text + "Values (";
			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				int Enumeracion = Convert.ToInt32(row.Cells["Enumeracion"].Value);
				if (Enumeracion > 1)
				{
					parametros = "@" + parametros + ",";
					txtInsertarSQLServer.Text = txtInsertarSQLServer.Text + "\r" + parametros;
				}
			}
			largo = txtInsertarSQLServer.Text.Length;
			txtInsertarSQLServer.Text = txtInsertarSQLServer.Text.Substring(0, largo - 1);
			txtInsertarSQLServer.Text = txtInsertarSQLServer.Text + ")";
		}
		public void editar()
		{
			use = "USE " + txtbasededatos.Text + "\r" + "GO" + "\r";
			tituloProcedimiento = "CREATE PROC editar_" + tabla;
			txtEditar.Text = use + tituloProcedimiento;
			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string tipo = Convert.ToString(row.Cells["Tipo"].Value);
				string longitud = Convert.ToString(row.Cells["Longitud"].Value);
				int enumeracion = Convert.ToInt32(row.Cells["Enumeracion"].Value);

				string longitudNumericaEntera = Convert.ToString(row.Cells["column1"].Value);
				string longitudNumericaDecimal = Convert.ToString(row.Cells["column2"].Value);



				if (enumeracion == 1)
				{
					id = parametros;
				}
				if (longitud == "-1")
				{
					longitud = "MAX";
				}
				string Longitud_completa = "(" + longitud + ")";
				if (string.IsNullOrEmpty(longitud))
				{
					if (tipo == "numeric" || tipo == "decimal")
					{
						string longitud_para_numericos = "(" + longitudNumericaEntera + "," + longitudNumericaDecimal + ")";
						parametros = "@" + parametros + " As " + Tipo + longitud_para_numericos + ",";
					}
					else
					{
						parametros = "@" + parametros + " As " + Tipo + ",";

					}

				}
				else if (!string.IsNullOrEmpty(longitud) && tipo != "image")
				{
					parametros = "@" + parametros + " As " + Tipo + Longitud_completa + ",";
				}
				else if (!string.IsNullOrEmpty(longitud) && tipo == "image")
				{
					parametros = "@" + parametros + " As " + Tipo + ",";
				}
				txtEditar.Text = txtEditar.Text + "\r" + parametros;

			}
			largo = txtEditar.Text.Length;
			txtEditar.Text = txtEditar.Text.Substring(0, largo - 1);
			txtEditar.Text = txtEditar.Text + "\r" + "As" + "\r";


			funcion = "UPDATE " + tabla + " Set" + "\r";


			txtEditar.Text = txtEditar.Text + funcion;
			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				int Enumeracion = Convert.ToInt32(row.Cells["Enumeracion"].Value);
				if (Enumeracion > 1)
				{
					parametros = parametros + "=@" + parametros + ",";
					txtEditar.Text = txtEditar.Text + "\r" + parametros;
				}
			}
			largo = txtEditar.Text.Length;
			txtEditar.Text = txtEditar.Text.Substring(0, largo - 1) + "\r" + "Where " + id + "=" + "@" + id;
		}
		/// <summary>
		/// Eliminar en SqlServer
		/// </summary>
		public void eliminar()
		{
			use = "USE " + txtbasededatos.Text + "\r" + "GO" + "\r";

			tituloProcedimiento = use + "CREATE PROC eliminar_" + (tabla + "\r");
			txtEliminar.Text = tituloProcedimiento;

			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{

				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);

				int Enumeracion = Convert.ToInt32(row.Cells["Enumeracion"].Value);

				if (Enumeracion == 1)
				{
					var parametro_puro = parametros;
					parametros = "@" + parametros + " As " + Tipo + "\r";
					txtEliminar.Text = txtEliminar.Text + parametros + "\r" + "As" + "\r";
					funcion = "DELETE FROM " + tabla + "\r";
					txtEliminar.Text = txtEliminar.Text + funcion;
					txtEliminar.Text = txtEliminar.Text + "WHERE " + parametro_puro + "=@" + parametro_puro;
				}
			}
		}

		public void mostrarsql()
		{
			use = "USE " + txtbasededatos.Text + "\r" + "GO" + "\r";

			tituloProcedimiento = use + "CREATE PROC mostrar_" + tabla;
			txtMostrar.Text = tituloProcedimiento;

			txtMostrar.Text = txtMostrar.Text + "\r" + "As" + "\r";
			funcion = "Select * FROM " + tabla + "\r";
			txtMostrar.Text = txtMostrar.Text + funcion;



		}
		public void crudSQLCompleto()
		{
			txtCrudSQLCompleto.Text = txtInsertarSQLServer.Text + "\r" + "\r" + txtEditar.Text + "\r" + "\r" + txtMostrar.Text + "\r" + "\r" + txtEliminar.Text;
		}

		public void SQLServer()
		{
			btnSQLSERVER.BackColor = Color.DodgerBlue;
			btnVb.BackColor = Color.FromArgb(45, 45, 48);
			btnCsharp.BackColor = Color.FromArgb(45, 45, 48);
			TSQLvolver.Visible = false;
			EvitarRepeticionesSQLServer.Checked = false;
			PanelSQLServer.Visible = true;
			PanelCsharp.Visible = false;


			InsertarSQLServer();
			editar();
			eliminar();
			crudSQLCompleto();
			

		}

        private void Generador_UI_Load(object sender, EventArgs e)
        {
			ReadfromXMLusuario();
			if (usuario == "NULO")
			{
				ReadfromXMLinstancia();
				basesDeDatos(servidor);
				Tamaño_automatico_de_datatables.Multilinea(ref datalistado_TABLAS);
				datalistado_TABLAS.Columns[0].Width = datalistado_TABLAS.Width - 50;
				txtbasededatos.DataSource = dt;
				txtbasededatos.DisplayMember = "name";
			}
			else
			{
				ReadfromXMLinstancia();
				ReadfromXMLcontrasenna();
				ReadfromXMLusuario();
				basesDeDatosContrasenna(servidor);

				Tamaño_automatico_de_datatables.Multilinea(ref datalistado_TABLAS);
				datalistado_TABLAS.Columns[0].Width = datalistado_TABLAS.Width - 50;
				txtbasededatos.DataSource = dt;
				txtbasededatos.DisplayMember = "name";
			}
			indicador = "SQLSERVER";
			PanelBienvenida.Visible = true;
			PanelBienvenida.Dock = DockStyle.Fill;
			PanelSQLServer.Dock = DockStyle.Fill;
			PanelCsharp.Dock = DockStyle.Fill;
			PanelVb.Dock = DockStyle.Fill;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		}

        private void VerCodigo_Click(object sender, EventArgs e)
        {
			indicador = "SQLSERVER";
			SQLServer();

		}
	}
}