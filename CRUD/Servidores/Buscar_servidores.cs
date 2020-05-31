using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using CRUD.Librerias;

namespace CRUD.Servidores
{
    public partial class Buscar_servidores : Form
    {
        private AES aes = new AES();
        private DataTable dt = new DataTable();
        private string usuario;
        private string[] bases;
        private string contraseña;
        private string servidor;
        public string NIVEL;
        private int contador;
        private string dbcnString;

        private static Buscar_servidores _DefaultInstance;
        public Buscar_servidores()
        {
            InitializeComponent();
        }

        private void Buscar_servidores_Load(object sender, EventArgs e)
        {
            panelBuscandoServidor.Location = new Point((Width - panelBuscandoServidor.Width) / 2, (Height - panelBuscandoServidor.Height) / 2);
            PanelSinServidor.Location = new Point((Width - PanelSinServidor.Width) / 2, (Height - PanelSinServidor.Height) / 2);
            Timer1.Start();
        }

        /// <summary>
        /// Compruebo las conexiones con el usuario
        /// </summary>
        public void comprobar_conexion_con_usuario()
        {
            basesDeDatosContrasenna(servidor);
            try
            {
                ComboBox1.DataSource = dt;
                ComboBox1.DisplayMember = "name";
            }
            catch(Exception ex)
            {

            }
            if(!string.IsNullOrEmpty(ComboBox1.Text))
            {
                saveInstancia(aes.Encrypt(txtinstancia.Text.Trim(), Desencryptacion.appPwdUnique, int.Parse("256")));
                saveusuario(aes.Encrypt(txtusuario.Text.Trim(), Desencryptacion.appPwdUnique, int.Parse("256")));
                savecontraseña(aes.Encrypt(txtcontraseña.Text.Trim(), Desencryptacion.appPwdUnique, int.Parse("256")));
                Dispose(); // se destruye la ejecución
                Generador_UI fm = new Generador_UI();
                fm.ShowDialog();

            } else
            {
                panelBuscandoServidor.Visible = false;
                PanelSinServidor.Visible = true;
            }
        }

        public void comprobar_conexiones()
        {
            if(string.IsNullOrEmpty(NIVEL))
            {
                ReadfromXMLcontrasenna();
                ReadfromXMLinstancia();
                ReadfromXMLusuario();
                if(usuario == "NULO")
                {
                    comprobar_conexion_sin_usuario();
                    if(string.IsNullOrEmpty(ComboBox1.Text))
                    {
                        comprobar_conexion_sin_usuario_y_si_aun_no_se_guarda_la_conexion();
                    }
                } else
                {
                    comprobar_conexion_sin_usuario_y_si_aun_no_se_guarda_la_conexion();
                    panelBuscandoServidor.Visible = true;
                    PanelSinServidor.Visible = false;

                    if(string.IsNullOrEmpty(ComboBox1.Text))
                    {
                        txtcontraseña.Text = contraseña;
                        txtusuario.Text = usuario;
                        comprobar_conexion_con_usuario();
                    }
                }
            }
            else
            {
                ReadfromXMLcontrasenna();
                ReadfromXMLinstancia();
                ReadfromXMLusuario();
                panelBuscandoServidor.Visible = false;
                //PanelSinServidor.Location = New Point((Width - PanelSinServidor.Width) / 2, (Height - PanelSinServidor.Height) / 2)
                PanelSinServidor.Visible = true;
            }
        }

        /// <summary>
        /// Compruebo la conexion que no tenga usuario y no este guardada  en sql
        /// </summary>
        public void comprobar_conexion_sin_usuario_y_si_aun_no_se_guarda_la_conexion()
        {
            string servidorsql = @".\SQLEXPRESS";
            baseDeDatos(servidorsql);

            try
            {
                ComboBox1.DataSource = dt;
                ComboBox1.DisplayMember = "name";   

            } catch( Exception ex)
            {

            }

            if(!string.IsNullOrEmpty(ComboBox1.Text)) {
                try
                {

                    saveInstancia(aes.Encrypt(servidor, Desencryptacion.appPwdUnique, int.Parse("256")));
                    saveusuario(aes.Encrypt("NULO", Desencryptacion.appPwdUnique, int.Parse("256")));
                    savecontraseña(aes.Encrypt("NULO", Desencryptacion.appPwdUnique, int.Parse("256")));
                    Dispose(); // se destruye
                    Generador_UI fm = new Generador_UI();
                    fm.ShowDialog();

                }
                catch(Exception ex)
                {

                }
            } else
            {
                // Conexion a sqlServer no express
                servidorsql = ".";
                baseDeDatos(servidorsql);

                try
                {
                    ComboBox1.DataSource = dt;
                    ComboBox1.DisplayMember = "name";
                }
                catch(Exception ex)
                {

                }

                if(!string.IsNullOrEmpty(ComboBox1.Text))
                {
                    try
                    {
                        saveInstancia(aes.Encrypt(servidorsql, Desencryptacion.appPwdUnique, int.Parse("256")));
                        saveusuario(aes.Encrypt("NULO", Desencryptacion.appPwdUnique, int.Parse("256")));
                        savecontraseña(aes.Encrypt("NULO", Desencryptacion.appPwdUnique, int.Parse("256")));
                        Dispose(); // se destruye
                        Generador_UI fm = new Generador_UI();
                        fm.ShowDialog();
                    }
                    catch(Exception ex)
                    {

                    }
                } else
                {
                    panelBuscandoServidor.Visible = false;
                    PanelSinServidor.Visible = true;
                }
            }

        }

        /// <summary>
        /// Comprobar la conexion sin usuario, cuando ya está guardada la conexión
        /// </summary>
        public  void comprobar_conexion_sin_usuario()
        {
            baseDeDatos(servidor);
            try
            {
                ComboBox1.DataSource = dt;
                ComboBox1.DisplayMember = "name";

            }
            catch(Exception ex)
            {

            }

            if(!string.IsNullOrEmpty(ComboBox1.Text))
            {
                try
                {
                    saveInstancia(aes.Encrypt(servidor, Desencryptacion.appPwdUnique, int.Parse("256")));
                    saveusuario(aes.Encrypt("NULO", Desencryptacion.appPwdUnique, int.Parse("256")));
                    savecontraseña(aes.Encrypt("NULO", Desencryptacion.appPwdUnique, int.Parse("256")));
                    Dispose(); // se destruye
                    Generador_UI fm = new Generador_UI();
                    fm.ShowDialog();
                }
                catch (Exception ex)
                {

                }
            }
        }





        /// <summary>
        /// Guardar las instancias
        /// </summary>
        /// <param name="dbcnString"></param>
        public void saveInstancia(object dbcnString)
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
        /// <summary>
        /// guardar el usuario
        /// </summary>
        /// <param name="dbcnString"></param>
        public void saveusuario(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("usuario.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes.Item(0).Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("usuario.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        /// <summary>
        /// guardar la contraseña
        /// </summary>
        /// <param name="dbcnString"></param>
        public void savecontraseña(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("contraseña.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes.Item(0).Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("contraseña.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        private string[] basesDeDatosContrasenna(string instancia)
        {

            string[] basesSys = { "master", "model", "msdb", "tempdb" };

            string sCnn = "Server=" + instancia + "; " + "database=master; integrated security=false; User=" + txtusuario.Text + "; password=" + txtcontraseña.Text;


            string sel = "SELECT name FROM sysdatabases";
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
            }
            catch (Exception ex)
            {


            }
            return null;

        }
        private string [] baseDeDatos(string  instancia)
        {
            string[] basesSys = { "master", "model", "msdb", "tempdb" };
            string conn = "Server=" + instancia + "; " + "database=master; integrated security=yes";

            string sel = "SELECT name FROM sysdatabases";

            try
            {

                SqlDataAdapter da = new SqlDataAdapter(sel, conn);
                da.Fill(dt);
                bases = new string[dt.Rows.Count];
                int k = -1;

                for(int i=0; i< dt.Rows.Count; i++)
                {
                    string s = dt.Rows[i]["name"].ToString();

                    if(Array.IndexOf(basesSys,s) == -1)
                    {
                        k += 1;
                        bases[k] = s;

                    }

                }

                if(k == -1)
                {
                    return null;
                }

                Array.Resize(ref bases, k + 1);
                return bases;


            } catch(Exception ex)
            {

            }
            return null;

        }

        /// <summary>
        /// Desencrypto la contraseña para leer el archivo
        /// </summary>
        public void ReadfromXMLcontrasenna()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("contraseña.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes.Item(0).Value;
                contraseña = (aes.Decrypt(dbcnString, Desencryptacion.appPwdUnique, int.Parse("256")));

            }catch(System.Security.Cryptography.CryptographicException ex)
            {

            }

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

        private void Buscar_servidores_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            contador += 1;
            if (contador == 40)
            {
                Timer1.Stop();
                comprobar_conexiones();
            }
        }

        public static Buscar_servidores DefaultInstance
        {
            get
            {
                if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
                    _DefaultInstance = new Buscar_servidores();

                return _DefaultInstance;
            }
        }
    }
}
