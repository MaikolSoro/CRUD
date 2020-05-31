using System;
using System.Collections;
using System.Collections.Generic;
using CRUD.Servidores;

namespace CRUD
{
	public partial class Presentacion
	{
		private int contador;
		private static Presentacion _DefaultInstance;

		public Presentacion()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Load donde se va ejecutar primero las acciones
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Presentacion_Load(object sender, EventArgs e)
		{


			Timer1.Start();

		}

		private void Label4_Click(object sender, EventArgs e)
		{



		}
		private void Timer1_Tick(object sender, EventArgs e)
		{
			contador += 1;
			if (contador == 30)
			{

			}
			else if (contador == 32)
			{
				Timer1.Stop();
				Dispose();
				Buscar_servidores.DefaultInstance.ShowDialog();
			}
		}


		public static Presentacion DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new Presentacion();

				return _DefaultInstance;
			}
		}
	}
}