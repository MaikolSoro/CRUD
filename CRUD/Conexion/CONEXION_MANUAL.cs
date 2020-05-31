using System;
using CRUD.Librerias;
using System.Xml;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CRUD
{
	public partial class CONEXION_MANUAL
	{
		private AES aes = new AES();
		private string dbcnString;
		public CONEXION_MANUAL()
		{
			InitializeComponent();
		}

		private void obtenerDatos()
        {
			string nombreHost = System.Net.Dns.GetHostName();
			System.Net.IPHostEntry hostInfo = System.Net.Dns.GetHostByName(nombreHost);

			foreach (System.Net.IPAddress ip in hostInfo.AddressList)
            {
				txtdatasource.Text = ip.ToString();
            }
        }

		public void SavetoXML(object dbcnString)
        {
			XmlDocument doc = new XmlDocument();
			doc.Load("ConnectionString.xml");
			XmlElement root = doc.DocumentElement;
			root.Attributes.Item(0).Value = Convert.ToString(dbcnString);
			XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
			writer.Formatting = Formatting.Indented;
			doc.Save(writer);
			writer.Close();

        }

		public void SavetoHTML(object dbcnString)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load("Diseño_html.xml");
			XmlElement root = doc.DocumentElement;
			root.Attributes.Item(0).Value = Convert.ToString(dbcnString);
			XmlTextWriter writer = new XmlTextWriter("Diseño_html.xml", null);
			writer.Formatting = Formatting.Indented;
			doc.Save(writer);
			writer.Close();
		}

		/// <summary>
		/// Guardar la conexion web
		/// </summary>
		/// <param name="dbcnString"></param>
		public void SavetoWeb(object dbcnString)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load("Conexion_web.xml");
			XmlElement root = doc.DocumentElement;
			root.Attributes.Item(0).Value = Convert.ToString(dbcnString);
			XmlTextWriter writer = new XmlTextWriter("Conexion_web.xml", null);
			writer.Formatting = Formatting.Indented;
			doc.Save(writer);
			writer.Close();
		}
		public void ReadfromXML()
		{

			try
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("ConnectionString.xml");
				XmlElement root = doc.DocumentElement;
				dbcnString = root.Attributes.Item(0).Value;
				txtCnString.Text = (aes.Decrypt(dbcnString, Desencryptacion.appPwdUnique, int.Parse("256")));

			}
			catch (System.Security.Cryptography.CryptographicException ex)
			{


			}
		}

		/// <summary>
		/// Leer conexion web
		/// </summary>
		public void ReadfromXMLWEB()
		{
			try
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("Conexion_web.xml");
				XmlElement root = doc.DocumentElement;
				dbcnString = root.Attributes.Item(0).Value;
				txtCnStringWEB.Text = (aes.Decrypt(dbcnString, Desencryptacion.appPwdUnique, int.Parse("256")));

			}
			catch (System.Security.Cryptography.CryptographicException ex)
			{

			}
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{

		}

        private void CONEXION_MANUAL_Load(object sender, EventArgs e)
        {
            obtenerDatos();
			ReadfromXML();
			//ReadfromXMLWEB();
		}

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
			if (string.IsNullOrEmpty(txtCnString.Text))
			{
				MessageBox.Show("Por favor ingrese la cadena de Conexion..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				SavetoXML(aes.Encrypt(txtCnString.Text, Desencryptacion.appPwdUnique, int.Parse("256")));
				//MessageBox.Show("Conexion Creada Archivo: ConnectionString.xml", "Encryptacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
				mostrar_usuario();

			}
		}

		public void mostrar_usuario()
        {
			try
            {
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter("select * from USUARIO2", txtCnString.Text);


				da.Fill(dt);
				datalistado_movimientos_validar.DataSource = dt;

				MessageBox.Show("Conexion Creada Correctamente, Abra de nuevo el Aplicativo", "Conexion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

				System.Environment.Exit(1);

			} catch(Exception ex)
            {
				MessageBox.Show("Conexion Fallida, Revisa de nuevo la Cadena de Conexion o Escribenos para Ayudarte de Inmediato", "Sin Conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


        private void Timer1_Tick(object sender, EventArgs e)
        {
			Timer1.Stop();
			mostrar_usuario();
		}


        private void Cerrar_Click(object sender, EventArgs e)
        {
			Close();
        }
		/// <summary>
		/// Generar la cadena de conexión
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GenerarConexionWeb_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(txtCnStringWEB.Text))
			{
				MessageBox.Show("Por favor ingrese la cadena de Conexion..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				SavetoWeb(aes.Encrypt(txtCnStringWEB.Text, Desencryptacion.appPwdUnique, int.Parse("256")));
				MessageBox.Show("Conexion Creada Archivo: ConnectionString.xml", "Encryptacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//Application.Exit()
			}
		}

		/// <summary>
		/// Mostrar la conexion web
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void MostrarConexionWeb_Click(object sender, EventArgs e)
        {
			obtenerDatos();
			ReadfromXMLWEB();
		}
    }
}