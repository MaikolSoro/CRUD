using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUD.Librerias
{
	internal static class Tamaño_automatico_de_datatables
	{
		public static void Multilinea(ref DataGridView List)
		{
			//List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
			//List.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
			List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

			List.EnableHeadersVisualStyles = false;
			DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
			styCabeceras.BackColor = Color.FromArgb(39, 39, 39);
			styCabeceras.ForeColor = Color.White;
			styCabeceras.Font = new Font("Segoe UI", 13, FontStyle.Regular | FontStyle.Bold);
			List.ColumnHeadersDefaultCellStyle = styCabeceras;
		}
	}
}
