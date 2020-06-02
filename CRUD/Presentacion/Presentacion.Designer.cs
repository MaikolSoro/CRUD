using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace CRUD
{
    public partial class Presentacion : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentacion));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.PictureBox3);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Location = new System.Drawing.Point(15, 30);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(763, 367);
            this.Panel1.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label2.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(0, -6);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(763, 100);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "CRUD";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(0, 94);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(763, 39);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Version Beta v.1.0.0";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PictureBox3.Image = global::CRUD.Properties.Resources.connec;
            this.PictureBox3.Location = new System.Drawing.Point(0, 133);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(763, 176);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 14;
            this.PictureBox3.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.PictureBox4);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Panel2.Location = new System.Drawing.Point(0, 309);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(763, 58);
            this.Panel2.TabIndex = 16;
            // 
            // PictureBox4
            // 
            this.PictureBox4.Image = global::CRUD.Properties.Resources.connec;
            this.PictureBox4.Location = new System.Drawing.Point(107, 4);
            this.PictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(53, 42);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox4.TabIndex = 1;
            this.PictureBox4.TabStop = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label6.Location = new System.Drawing.Point(168, 17);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(232, 17);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Desarrollado por MichaelSoro";
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 425);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.Presentacion_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            this.ResumeLayout(false);

        }
        internal Timer Timer1;
        internal Panel Panel1;
        internal Label Label2;
        internal Label Label3;
        internal PictureBox PictureBox3;
        internal Panel Panel2;
        internal PictureBox PictureBox4;
        internal Label Label6;
    }

}