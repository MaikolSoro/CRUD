using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
		private string indicador_de_parametros;
		public string tituloProcedimiento;
		public string funcion;
		public string valores;
		public int largo;
		public string tabla;
		private string[] bases;
		private string dbcnString;
		private string servidor;
		private string usuario;
		private string contrasenna;
		private string use;
		private string indicador;
		private int contador;
		private string id;
		private string ruta;
		private DataTable dt = new DataTable();
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
			mostrarsql();
			eliminar();
			crudSQLCompleto();
			

		}

		public void insertar_vb()
		{
			string PROCESO = "Public Sub " + "Insertar_" + tabla + "\r";
			string nombre_scrypt = "Insertar_" + tabla;
			string L1 = PROCESO + "Try" + "\r";
			string L2 = "abrir()" + "\r";
			string L3 = "Dim cmd As New SqlCommand" + "\r";
			string L4 = "cmd = New SqlCommand(" + labelComillas.Text + nombre_scrypt + labelComillas.Text + ", conexion)" + "\r";
			string L5 = "cmd.CommandType = 4" + "\r";
			txtInsertarVb.Text = L1 + L2 + L3 + L4 + L5;

			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);
				int Enumeracion = Convert.ToInt32(row.Cells["Enumeracion"].Value);
				if (Enumeracion > 1)
				{
					string Tipo = Convert.ToString(row.Cells["Tipo"].Value);
					if (Tipo != "Image")
					{
						parametros = "@" + parametros;
						string cmdparametro = "cmd.Parameters.AddWithValue(" + labelComillas.Text + parametros + labelComillas.Text + ", txt" + parametros2 + ".Text)";
						txtInsertarVb.Text = txtInsertarVb.Text + "\r" + cmdparametro;
					}
				}


			}

			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);
				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);
				int Enumeracion = Convert.ToInt32(row.Cells["Enumeracion"].Value);
				if (Enumeracion > 1)
				{
					if (Tipo == "image")
					{
						parametros = "@" + parametros;
						string L6 = "Dim ms As New IO.MemoryStream()" + "\r";
						string L7 = "AQUI_el_nombre_de_TU_PICTUREBOX.Image.Save(ms, AQUI_el_nombre_de_TU_PICTUREBOX.Image.RawFormat)" + "\r";
						string L8 = "cmd.Parameters.AddWithValue(" + labelComillas.Text + parametros + labelComillas.Text + ", ms.GetBuffer)" + "\r";

						string LUNIDOS = "\r" + L6 + L7 + L8;
						txtInsertarVb.Text = txtInsertarVb.Text + LUNIDOS;
					}
				}

			}
			string L9 = "\r" + "cmd.ExecuteNonQuery()" + "\r";
			string L10 = "Cerrar()" + "\r";
			string L11 = "Catch ex As Exception" + "\r";
			string L12 = "MsgBox(ex.StackTrace)" + "\r";
			string L13 = "End Try";
			txtInsertarVb.Text = txtInsertarVb.Text + L9 + L10 + L11 + L12 + L13 + "\r" + "End Sub";


		}

		public void mostrar_vb()
		{
			string L1 = "Public Sub " + "mostrar_" + tabla + "_en_datagridview" + "\r";
			string L2 = "Dim dt As New DataTable" + "\r";
			string L3 = "Dim da As SqlDataAdapter" + "\r";
			string L4 = "Try" + "\r";
			string L5 = "abrir()" + "\r";
			string nombre_scrypt2 = "mostrar_" + tabla;
			string L6 = "da = New SqlDataAdapter(" + labelComillas.Text + nombre_scrypt2 + labelComillas.Text + ", conexion)" + "\r";
			string L7 = "da.Fill(dt)" + "\r";
			string L8 = "Tu_datagridview.DataSource = dt" + "\r";
			string L9 = "Cerrar()" + "\r";
			string L10 = "Catch ex As Exception" + "\r";
			string L11 = "MessageBox.Show(ex.StackTrace)" + "\r";
			string L12 = "End Try";
			txtMostrarVb.Text = L1 + L2 + L3 + L4 + L5 + L6 + L7 + L8 + L9 + L10 + L11 + L12 + "\r" + "End Sub";
		}

		public void editar_vb()
		{
			string PROCESO = "Public Sub " + "editar_" + tabla + "\r";
			string nombre_scrypt = "Editar_" + tabla;
			string L1 = PROCESO + "Try" + "\r";
			string L2 = "abrir()" + "\r";
			string L3 = "Dim cmd As New SqlCommand" + "\r";
			string L4 = "cmd = New SqlCommand(" + labelComillas.Text + nombre_scrypt + labelComillas.Text + ", conexion)" + "\r";
			string L5 = "cmd.CommandType = 4" + "\r";
			txtEditarVb.Text = L1 + L2 + L3 + L4 + L5;

			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);

				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);
				if (Tipo != "image")
				{
					parametros = "@" + parametros;
					string cmdparametro = "cmd.Parameters.AddWithValue(" + labelComillas.Text + parametros + labelComillas.Text + ", txt" + parametros2 + ".Text)";
					txtEditarVb.Text = txtEditarVb.Text + "\r" + cmdparametro;
				}



			}

			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);
				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);

				if (Tipo == "image")
				{
					parametros = "@" + parametros;
					string L6 = "Dim ms As New IO.MemoryStream()" + "\r";
					string L7 = "AQUI_el_nombre_de_TU_PICTUREBOX.Image.Save(ms, AQUI_el_nombre_de_TU_PICTUREBOX.Image.RawFormat)" + "\r";
					string L8 = "cmd.Parameters.AddWithValue(" + labelComillas.Text + parametros + labelComillas.Text + ", ms.GetBuffer)" + "\r";

					string LUNIDOS = "\r" + L6 + L7 + L8;
					txtEditarVb.Text = txtEditarVb.Text + LUNIDOS;
				}


			}
			string L9 = "\r" + "cmd.ExecuteNonQuery()" + "\r";
			string L10 = "Cerrar()" + "\r";
			string L11 = "Catch ex As Exception" + "\r";
			string L12 = "MsgBox(ex.StackTrace)" + "\r";
			string L13 = "End Try";
			txtEditarVb.Text = txtEditarVb.Text + L9 + L10 + L11 + L12 + L13 + "\r" + "End Sub";

		}
		public void VisualBasic()
		{
			btnVb.BackColor = Color.DodgerBlue;
			btnSQLSERVER.BackColor = Color.FromArgb(45, 45, 48);
			btnCsharp.BackColor = Color.FromArgb(45, 45, 48);
			
			mostrar_vb();
			insertar_vb();
			editar_vb();
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

		private void psEstructura_Tabla(string strTabla)
		{
			string msCadenaSQL = "Data Source=" + servidor + ";Initial Catalog=" + txtbasededatos.Text + ";Integrated Security=True";
			if (indicador_de_parametros == "CSHARP")
			{
				this.datalistadoEstructuraCONParametros.Rows.Clear();
			}
			else
			{
				this.datalistadoEstructura.Rows.Clear();
			}
			try
			{
				SqlConnection conConexion = new SqlConnection(msCadenaSQL);
				SqlCommand coSQL = new SqlCommand(@"Select *" + " FROM INFORMATION_SCHEMA." + "COLUMNS WHERE TABLE_NAME='" + strTabla + "'", conConexion);
				SqlDataReader drColumnas = null;
				conConexion.Open();
				drColumnas = coSQL.ExecuteReader();
				while (drColumnas.Read())
				{
					if (indicador_de_parametros == "CSHARP")
					{
						this.datalistadoEstructuraCONParametros.Rows.Add(drColumnas["COLUMN_NAME"], drColumnas["DATA_TYPE"], drColumnas["CHARACTER_MAXIMUM_LENGTH"], drColumnas["NUMERIC_PRECISION"], drColumnas["NUMERIC_SCALE"], drColumnas[5].ToString(), drColumnas[1].ToString(), drColumnas[2].ToString(), drColumnas[3].ToString(), drColumnas[4].ToString(), drColumnas[5].ToString(), drColumnas[7].ToString(), drColumnas[8].ToString(), drColumnas[9].ToString(), drColumnas[10].ToString(), drColumnas[11].ToString(), drColumnas[12].ToString());
					}
					else
					{
						this.datalistadoEstructura.Rows.Add(drColumnas["COLUMN_NAME"], drColumnas["DATA_TYPE"], drColumnas["CHARACTER_MAXIMUM_LENGTH"], drColumnas["NUMERIC_PRECISION"], drColumnas["NUMERIC_SCALE"], drColumnas[5].ToString(), drColumnas[1].ToString(), drColumnas[2].ToString(), drColumnas[3].ToString(), drColumnas[4].ToString(), drColumnas[5].ToString(), drColumnas[7].ToString(), drColumnas[8].ToString(), drColumnas[9].ToString(), drColumnas[10].ToString(), drColumnas[11].ToString(), drColumnas[12].ToString());
					}

				}
				drColumnas.Close();
				conConexion.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void psEstructura_TablaContrasenna(string strTabla)
		{
			string msCadenaSQL = "Data Source=" + servidor + ";Initial Catalog=" + txtbasededatos.Text + ";Integrated Security=false; " + "User Id=" + usuario + ";Password=" + contrasenna;

			this.datalistadoEstructura.Rows.Clear();
			try
			{
				SqlConnection conConexion = new SqlConnection(msCadenaSQL);
				SqlCommand coSQL = new SqlCommand(@"SELECT COLUMN_NAME,DATA_TYPE,” _
                                        & “CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE FROM INFORMATION_SCHEMA.” _
                                        & “COLUMNS WHERE TABLE_NAME='" + strTabla + "'", conConexion);
				SqlDataReader drColumnas = null;
				conConexion.Open();
				drColumnas = coSQL.ExecuteReader();
				while (drColumnas.Read())
				{

					this.datalistadoEstructura.Rows.Add(drColumnas["COLUMN_NAME"], drColumnas["DATA_TYPE"]);
				}
				drColumnas.Close();
				conConexion.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Formulas_Click(object sender, EventArgs e)
        {
			indicador = "VB";


			PanelSQLServer.Visible = false;
			PanelCsharp.Visible = false;
			PanelVb.Visible = true;



			try
			{
				tabla = Convert.ToString(this.datalistado_TABLAS.SelectedCells[0].Value);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
			}
			if (usuario == "NULO")
			{
				this.psEstructura_Tabla(tabla);
			}
			else
			{
				this.psEstructura_TablaContrasenna(tabla);
			}
			VisualBasic();
		}

		public void insertar_C_sharp()
		{
			string proceso = "private void " + "Insertar_" + tabla + "(" + ")" + "\r" + "{" + "\r";

			string nombre_scrypt2 = "Insertar_" + tabla;
			string L1 = proceso + "try" + "\r" + "{" + "\r";

			string L2 = "CONEXION.CONEXIONMAESTRA.abrir();" + "\r";
			string L4 = "SqlCommand cmd = new SqlCommand(" + labelComillas.Text + nombre_scrypt2 + labelComillas.Text + ", CONEXION.CONEXIONMAESTRA.conectar);" + "\r";
			string L5 = "cmd.CommandType = CommandType.StoredProcedure;";
			txtInsertarCsharp.Text = L1 + L2 + L4 + L5;

			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);
				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);
				int Enumeracion = Convert.ToInt32(row.Cells["Enumeracion"].Value);
				if (Enumeracion > 1)
				{
					if (Tipo != "image")
					{
						parametros = "@" + parametros;
						string cmdparametro = "cmd.Parameters.AddWithValue(" + labelComillas.Text + parametros + labelComillas.Text + ", txt" + parametros2 + ".Text);";
						txtInsertarCsharp.Text = txtInsertarCsharp.Text + "\r" + cmdparametro;
					}
				}

			}

			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);
				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);

				if (Tipo == "image")
				{
					parametros = "@" + parametros;
					string L6 = "System.IO.MemoryStream ms = new System.IO.MemoryStream();" + "\r";
					string L7 = "AQUI_el_nombre_de_TU_PICTUREBOX.Image.Save(ms, AQUI_el_nombre_de_TU_PICTUREBOX.Image.RawFormat);" + "\r";
					string L8 = "cmd.Parameters.AddWithValue(" + labelComillas.Text + parametros + labelComillas.Text + ", ms.GetBuffer());" + "\r";

					string LUNIDOS = "\r" + L6 + L7 + L8;
					txtInsertarCsharp.Text = txtInsertarCsharp.Text + LUNIDOS;
				}
			}
			string L9 = "\r" + "cmd.ExecuteNonQuery();" + "\r";
			string L10 = "CONEXION.CONEXIONMAESTRA.Cerrar();" + "\r";
			string llave2 = "}" + "\r";
			string L11 = llave2 + "catch (Exception ex)" + "\r";
			string llave3 = "{" + "\r";
			string L12 = "MessageBox.Show(ex.StackTrace);" + "\r";
			string L13 = "}";
			txtInsertarCsharp.Text = txtInsertarCsharp.Text + L9 + L10 + L11 + llave3 + L12 + L13 + "\r" + "}";



		}

		public void editar_C_sharp()
		{
			string proceso = "Private void " + "editar" + tabla + "(" + ")" + "\r" + "{" + "\r";

			string nombre_scrypt2 = "editar_" + tabla;
			string L1 = proceso + "Try" + "\r" + "{" + "\r";
			string L2 = "CONEXION.CONEXIONMAESTRA.abrir();" + "\r";
			string L4 = "SqlCommand cmd = New SqlCommand(" + labelComillas.Text + nombre_scrypt2 + labelComillas.Text + ", CONEXION.CONEXIONMAESTRA.conectar);" + "\r";
			string L5 = "cmd.CommandType = CommandType.StoredProcedure;";
			txtEditarCsharp.Text = L1 + L2 + L4 + L5;

			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);
				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);
				if (Tipo != "image")
				{
					parametros = "@" + parametros;
					string cmdparametro = "cmd.Parameters.AddWithValue(" + labelComillas.Text + parametros + labelComillas.Text + ", txt" + parametros2 + ".Text);";
					txtEditarCsharp.Text = txtEditarCsharp.Text + "\r" + cmdparametro;
				}
			}

			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);
				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);

				if (Tipo == "image")
				{
					parametros = "@" + parametros;
					string L6 = "System.IO.MemoryStream ms = New System.IO.MemoryStream();" + "\r";
					string L7 = "AQUI_el_nombre_de_TU_PICTUREBOX.Image.Save(ms, AQUI_el_nombre_de_TU_PICTUREBOX.Image.RawFormat);" + "\r";
					string L8 = "cmd.Parameters.AddWithValue(" + labelComillas.Text + parametros + labelComillas.Text + ", ms.GetBuffer());" + "\r";

					string LUNIDOS = "\r" + L6 + L7 + L8;
					txtEditarCsharp.Text = txtEditarCsharp.Text + LUNIDOS;
				}
			}
			string L9 = "\r" + "cmd.ExecuteNonQuery();" + "\r";
			string L10 = "CONEXION.CONEXIONMAESTRA.Cerrar();" + "\r";
			string llave2 = "}" + "\r";
			string L11 = llave2 + "catch (Exception ex)" + "\r";
			string llave3 = "{" + "\r";
			string L12 = "MessageBox.Show(ex.StackTrace);" + "\r";
			string L13 = "}";
			txtEditarCsharp.Text = txtEditarCsharp.Text + L9 + L10 + L11 + llave3 + L12 + L13 + "\r" + "}";


		}

		public void mostrar_datagridview_C_sharp()
		{
			string proceso = null;
			string L4 = null;
			proceso = "Private void " + "mostrar_en_Datagridview_" + tabla + "(" + ")" + "\r" + "{" + "\r";

			string nombre_scrypt2 = "mostrar_" + tabla;
			string L1 = proceso + "Try" + "\r" + "{" + "\r";
			var indicar_parametro = "da.SelectCommand.CommandType = CommandType.StoredProcedure;";
			string L2 = "CONEXION.CONEXIONMAESTRA.abrir();" + "\r";

			L4 = "da = New SqlDataAdapter(" + labelComillas.Text + nombre_scrypt2 + labelComillas.Text + ", CONEXION.CONEXIONMAESTRA.conectar);" + "\r";

			txtMostrarCsharp.Text = L1 + L2 + L4;
			if (ConParametrosCsharp.Checked == true)
			{
				foreach (DataGridViewRow row in datalistadoEstructuraCONParametros.Rows)
				{
					bool Marcar = false;
					Marcar = Convert.ToBoolean(row.Cells["Marcar"].Value);
					if (Marcar)
					{
						string parametros = Convert.ToString(row.Cells["Parametros2"].Value);
						string parametros2 = Convert.ToString(row.Cells["Parametros2"].Value);
						string Tipo = Convert.ToString(row.Cells["Tipo2"].Value);
						if (Tipo != "image")
						{
							parametros = "@" + parametros;
							string cmdparametro = "cmd.Parameters.AddWithValue(" + labelComillas.Text + parametros + labelComillas.Text + ", txt" + parametros2 + ".Text);";
							txtMostrarCsharp.Text = txtMostrarCsharp.Text + "\r" + cmdparametro;
						}
					}
				}
				string L5 = "da.Fill(dt);" + "\r" + "Tu_Datagridview.DataSource = dt;" + "\r" + "CONEXION.CONEXIONMAESTRA.Cerrar();" + "\r";
				string L6 = "}" + "\r" + "catch (Exception ex)" + "\r" + "{" + "\r" + "MessageBox.Show(ex.StackTrace);" + "\r" + "}" + "\r" + "}";
				txtMostrarCsharp.Text = txtMostrarCsharp.Text + "\r" + L5 + L6;
			}
			else
			{
				string L5 = "da.Fill(dt);" + "\r" + "Tu_Datagridview.DataSource = dt;" + "\r" + "CONEXION.CONEXIONMAESTRA.Cerrar();" + "\r";
				string L6 = "}" + "\r" + "catch (Exception ex)" + "\r" + "{" + "\r" + "MessageBox.Show(ex.StackTrace);" + "\r" + "}" + "\r" + "}";
				txtMostrarCsharp.Text = txtMostrarCsharp.Text + L5 + L6;
			}
			
		}

		public void csharp()
		{
			btnCsharp.BackColor = Color.DodgerBlue;
			btnVb.BackColor = Color.FromArgb(45, 45, 48);
			btnSQLSERVER.BackColor = Color.FromArgb(45, 45, 48);
			ConParametrosCsharp.Checked = false;
			PanelSQLServer.Visible = false;
			PanelCsharp.Visible = true;

			insertar_C_sharp();
			editar_C_sharp();
			mostrar_datagridview_C_sharp();
		}

		public void ejecutar_scryt_crearProcedimientos_almacenados()
		{

			ruta = Path.Combine(Directory.GetCurrentDirectory(), "CRUD369" + ".txt");

			FileInfo fi = new FileInfo(ruta);
			StreamWriter sw = null;

			try
			{
				if (File.Exists(ruta) == false)
				{

					sw = File.CreateText(ruta);
					sw.WriteLine(txtCrear_procedimientos.Text);
					sw.Flush();
					sw.Close();
				}
				else if (File.Exists(ruta) == true)
				{
					File.Delete(ruta);
					sw = File.CreateText(ruta);
					sw.WriteLine(txtCrear_procedimientos.Text);
					sw.Flush();
					sw.Close();
				}
			}
			catch (Exception ex)
			{

			}

			try
			{
				Process Pross = new Process();

				Pross.StartInfo.FileName = "sqlcmd";
				Pross.StartInfo.Arguments = " -S " + servidor + " -i " + "CRUD369" + ".txt";
				Pross.Start();
				MessageBox.Show("Proceso ejecutado", "Listo");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al ejecutar", "Listo");

			}


		}

        private void btnCsharp_Click(object sender, EventArgs e)
        {
			try
			{
				indicador = "C#";


				try
				{

					PanelSQLServer.Visible = false;
					PanelCsharp.Visible = true;
					PanelVb.Visible = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.StackTrace);
				}


				contador = 0;
				try
				{
					tabla = Convert.ToString(this.datalistado_TABLAS.SelectedCells[0].Value);

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.StackTrace);
				}
				if (usuario == "NULO")
				{
					this.psEstructura_Tabla(tabla);
				}
				else
				{
					this.psEstructura_TablaContrasenna(tabla);
				}
				csharp();
			}
			catch (Exception ex)
			{

			}

		}

        private void Button9_Click(object sender, EventArgs e)
        {
			Clipboard.SetText(txtEditar.Text);
		}

        private void Button11_Click(object sender, EventArgs e)
        {
			InsertarSQLServer();
			Clipboard.SetText(txtEliminar.Text);
		}

        private void Button13_Click(object sender, EventArgs e)
        {
			Clipboard.SetText(txtMostrar.Text);
		}

		private void LblInsertar_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string tipo = Convert.ToString(row.Cells["Parametros"].Value);
				ComboBox1.Items.Add(tipo);
			}
		}
		private void Button10_Click(object sender, EventArgs e)
        {
			txtCrear_procedimientos.Text = txtEditar.Text;
			ejecutar_scryt_crearProcedimientos_almacenados();
		}

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;


			btnMaximizar.Visible = false;
			btnRestaurar.Visible = true;
			this.WindowState = FormWindowState.Maximized;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		}

        private void btnMinizar_Click(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Minimized;
		}

		public void maximizar()
		{
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;


			btnMaximizar.Visible = false;
			btnRestaurar.Visible = true;
			this.WindowState = FormWindowState.Maximized;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		}

        private void PictureBox3_Click(object sender, EventArgs e)
        {
			maximizar();
		}

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
			restaurar();
		}
		public void restaurar()
		{
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.WindowState = FormWindowState.Normal;
			btnRestaurar.Visible = false;
			btnMaximizar.Visible = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		}
		public void CapaModeloCsharp()
		{
			string privado = "private ";
			string tipos_de_datos = null;
			string puntocoma = ";";
			string proceso = "public ";
			string Capsula = null;
			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);
				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);
				if (Tipo == "varchar")
				{
					Tipo = "string";
				}
				if (Tipo == "image")
				{
					Tipo = "byte[]";
				}
				txtModeloCsharp.Text = txtModeloCsharp.Text + privado + Tipo + " _" + parametros + puntocoma + "\r";

			}
			foreach (DataGridViewRow row in datalistadoEstructura.Rows)
			{
				string parametros = Convert.ToString(row.Cells["Parametros"].Value);
				string parametros2 = Convert.ToString(row.Cells["Parametros"].Value);
				string Tipo = Convert.ToString(row.Cells["Tipo"].Value);
				if (Tipo == "varchar")
				{
					Tipo = "string";
				}
				if (Tipo == "image")
				{
					Tipo = "byte[]";
				}

				Capsula = proceso + Tipo + " " + parametros + "\r" + "{" + "\r" + "get " + "{ " + "return _" + parametros + puntocoma + " }" + "\r" + "set " + "{ _" + parametros + " = " + "value" + puntocoma + " }" + "\r" + "}";
				txtModeloCsharp.Text = txtModeloCsharp.Text + Capsula;
			}

		}
		private void BtnMVVC_Click(object sender, EventArgs e)
        {
			PanelSQLServer.Visible = false;
			PanelCsharp.Visible = false;
			PanelVb.Visible = false;
			PanelMvvcCsharp.Visible = true;
			CapaModeloCsharp();
		}

        private void ToolStripEjecutar_Click(object sender, EventArgs e)
        {
			InsertarSQLServer();
			txtCrear_procedimientos.Text = txtInsertarSQLServer.Text;
			ejecutar_scryt_crearProcedimientos_almacenados();
		}

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
			InsertarSQLServer();
			txtCrear_procedimientos.Text = txtInsertarSQLServer.Text + "\r" + "GO" + "\r" + txtEditar.Text + "\r" + "GO" + "\r" + txtMostrar.Text + "\r" + "GO" + "\r" + txtEliminar.Text;
			ejecutar_scryt_crearProcedimientos_almacenados();
		}
    
    }
}