﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CRUD.Servidores;

namespace CRUD
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var main = new Servidores.Buscar_servidores();
            //main.FormClosed += new FormClosedEventHandler(FormClosed);
            //main.Show();
            Application.Run(new Generador_UI());
        }

        private static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;

            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
