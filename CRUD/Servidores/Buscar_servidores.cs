using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUD.Servidores
{
    public partial class Buscar_servidores : Form
    {
        public Buscar_servidores()
        {
            InitializeComponent();
        }

        private void Buscar_servidores_Load(object sender, EventArgs e)
        {
            panelBuscandoServidor.Location = new Point((Width - panelBuscandoServidor.Width) / 2, (Height - panelBuscandoServidor.Height) / 2);
            PanelSinServidor.Location = new Point((Width - PanelSinServidor.Width) / 2, (Height - PanelSinServidor.Height) / 2);

        }
    }
}
