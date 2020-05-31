using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using CRUD.Librerias;

namespace CRUD.Conexion
{
	internal static class ConexionWeb
	{
		public static SqlConnection conexionWEB = new SqlConnection(Convert.ToString(Desencryptacion.checkServerWEB()));
		public static void abrirWEB()
		{
			if ((int)conexionWEB.State == 0)
			{
				conexionWEB.Open();
			}
		}
		public static void CerrarWEB()
		{
			if (conexionWEB.State == (System.Data.ConnectionState)1)
			{
				conexionWEB.Close();
			}
		}
	}
}
