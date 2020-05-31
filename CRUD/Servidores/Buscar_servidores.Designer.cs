using System.Data.SqlClient;
using System.Configuration;
using System.Xml;

//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace CRUD.Servidores
{
    public partial class Buscar_servidores : System.Windows.Forms.Form
    {
        //Form reemplaza a Dispose para limpiar la lista de componentes.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        //NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        //Se puede modificar usando el Diseñador de Windows Forms.  
        //No lo modifique con el editor de código.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_servidores));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSinServidor = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtinstancia = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panelBuscandoServidor = new System.Windows.Forms.Panel();
            this.estado_conexion = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.estado_conexionNOEXPRESS = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label6 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.PanelSinServidor.SuspendLayout();
            this.panelBuscandoServidor.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PictureBox1.Image = global::CRUD.Properties.Resources.connec;
            this.PictureBox1.Location = new System.Drawing.Point(16, 15);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(175, 172);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // PanelSinServidor
            // 
            this.PanelSinServidor.Controls.Add(this.Button1);
            this.PanelSinServidor.Controls.Add(this.Panel4);
            this.PanelSinServidor.Controls.Add(this.txtcontraseña);
            this.PanelSinServidor.Controls.Add(this.Label5);
            this.PanelSinServidor.Controls.Add(this.Panel3);
            this.PanelSinServidor.Controls.Add(this.txtusuario);
            this.PanelSinServidor.Controls.Add(this.Label4);
            this.PanelSinServidor.Controls.Add(this.Panel2);
            this.PanelSinServidor.Controls.Add(this.txtinstancia);
            this.PanelSinServidor.Controls.Add(this.Label3);
            this.PanelSinServidor.Controls.Add(this.Label2);
            this.PanelSinServidor.Controls.Add(this.Label1);
            this.PanelSinServidor.Location = new System.Drawing.Point(104, 415);
            this.PanelSinServidor.Margin = new System.Windows.Forms.Padding(4);
            this.PanelSinServidor.Name = "PanelSinServidor";
            this.PanelSinServidor.Size = new System.Drawing.Size(897, 517);
            this.PanelSinServidor.TabIndex = 18;
            this.PanelSinServidor.Visible = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button1.Location = new System.Drawing.Point(319, 411);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(339, 58);
            this.Button1.TabIndex = 23;
            this.Button1.Text = "Conectar";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Silver;
            this.Panel4.Location = new System.Drawing.Point(317, 391);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(323, 1);
            this.Panel4.TabIndex = 22;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtcontraseña.ForeColor = System.Drawing.Color.White;
            this.txtcontraseña.Location = new System.Drawing.Point(319, 356);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(321, 27);
            this.txtcontraseña.TabIndex = 21;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label5.Location = new System.Drawing.Point(163, 353);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(142, 29);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Contraseña:";
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Silver;
            this.Panel3.Location = new System.Drawing.Point(317, 337);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(323, 1);
            this.Panel3.TabIndex = 19;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtusuario.ForeColor = System.Drawing.Color.White;
            this.txtusuario.Location = new System.Drawing.Point(319, 302);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(321, 27);
            this.txtusuario.TabIndex = 18;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label4.Location = new System.Drawing.Point(205, 302);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(102, 29);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Usuario:";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.Location = new System.Drawing.Point(317, 286);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(323, 1);
            this.Panel2.TabIndex = 16;
            // 
            // txtinstancia
            // 
            this.txtinstancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtinstancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtinstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtinstancia.ForeColor = System.Drawing.Color.White;
            this.txtinstancia.Location = new System.Drawing.Point(319, 250);
            this.txtinstancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtinstancia.Name = "txtinstancia";
            this.txtinstancia.Size = new System.Drawing.Size(321, 27);
            this.txtinstancia.TabIndex = 15;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label3.Location = new System.Drawing.Point(197, 247);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 29);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Servidor:";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.DarkGray;
            this.Label2.Location = new System.Drawing.Point(0, 166);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(897, 65);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Ingrese los datos Manualmente";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(897, 166);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Servidor";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBuscandoServidor
            // 
            this.panelBuscandoServidor.Controls.Add(this.estado_conexion);
            this.panelBuscandoServidor.Location = new System.Drawing.Point(104, 219);
            this.panelBuscandoServidor.Margin = new System.Windows.Forms.Padding(4);
            this.panelBuscandoServidor.Name = "panelBuscandoServidor";
            this.panelBuscandoServidor.Size = new System.Drawing.Size(816, 188);
            this.panelBuscandoServidor.TabIndex = 19;
            // 
            // estado_conexion
            // 
            this.estado_conexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.estado_conexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.estado_conexion.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Bold);
            this.estado_conexion.ForeColor = System.Drawing.Color.White;
            this.estado_conexion.Location = new System.Drawing.Point(0, 0);
            this.estado_conexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estado_conexion.Name = "estado_conexion";
            this.estado_conexion.Size = new System.Drawing.Size(816, 171);
            this.estado_conexion.TabIndex = 13;
            this.estado_conexion.Text = "Buscando Servidor";
            this.estado_conexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Font = new System.Drawing.Font("Consolas", 16F);
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(65, 34);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(344, 40);
            this.ComboBox1.TabIndex = 20;
            // 
            // estado_conexionNOEXPRESS
            // 
            this.estado_conexionNOEXPRESS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.estado_conexionNOEXPRESS.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Bold);
            this.estado_conexionNOEXPRESS.ForeColor = System.Drawing.Color.White;
            this.estado_conexionNOEXPRESS.Location = new System.Drawing.Point(481, 36);
            this.estado_conexionNOEXPRESS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estado_conexionNOEXPRESS.Name = "estado_conexionNOEXPRESS";
            this.estado_conexionNOEXPRESS.Size = new System.Drawing.Size(816, 38);
            this.estado_conexionNOEXPRESS.TabIndex = 21;
            this.estado_conexionNOEXPRESS.Text = "Buscando Servidor";
            this.estado_conexionNOEXPRESS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.ComboBox1);
            this.Panel1.Controls.Add(this.estado_conexionNOEXPRESS);
            this.Panel1.Location = new System.Drawing.Point(251, 17);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(13, 12);
            this.Panel1.TabIndex = 22;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(55, 14);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(55, 17);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "usuario";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 10;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Buscar_servidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1339, 922);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.panelBuscandoServidor);
            this.Controls.Add(this.PanelSinServidor);
            this.Controls.Add(this.PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buscar_servidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Buscar_servidores_FormClosing);
            this.Load += new System.EventHandler(this.Buscar_servidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.PanelSinServidor.ResumeLayout(false);
            this.PanelSinServidor.PerformLayout();
            this.panelBuscandoServidor.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        internal PictureBox PictureBox1;
        internal Panel PanelSinServidor;
        internal Label Label2;
        internal Label Label1;
        internal Panel panelBuscandoServidor;
        internal Label estado_conexion;
        internal ComboBox ComboBox1;
        internal Label estado_conexionNOEXPRESS;
        internal Panel Panel1;
        internal Panel Panel4;
        internal TextBox txtcontraseña;
        internal Label Label5;
        internal Panel Panel3;
        internal TextBox txtusuario;
        internal Label Label4;
        internal Panel Panel2;
        internal TextBox txtinstancia;
        internal Label Label3;
        internal Button Button1;
        internal Label Label6;
        internal Timer Timer1;
    }

}