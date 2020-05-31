using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using CRUD.Librerias;

namespace CRUD.Conexion
{
    internal static class Conexion
    {

        public static SqlConnection connection = new SqlConnection(Convert.ToString(Desencryptacion.checkServer()));

        /// <summary>
        /// Abrir la conexión
        /// </summary>
        public static void abrir()
        {
            if((int)connection.State == 0)
            {
                connection.Open();
            }
        }

        public static void cerrar()
        {
            if(connection.State == (System.Data.ConnectionState)1)
            {
                connection.Close();
            }
        }

    }
}
