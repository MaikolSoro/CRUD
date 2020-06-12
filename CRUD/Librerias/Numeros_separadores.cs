using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD.Librerias
{

	internal static class Numeros_separadores
	{

		public static object Separador_de_Numeros(System.Windows.Forms.TextBox CajaTexto, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".")) != 0)
			{
				e.Handled = true;
			}
			else if (e.KeyChar == '.')
			{
				e.Handled = false;
			}
			else if (e.KeyChar == ',')
			{
				e.Handled = false;

			}
			else
			{
				e.Handled = true;

			}


			return null;
		}
	}

}