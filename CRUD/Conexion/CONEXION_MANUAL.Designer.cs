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

namespace CRUD
{
    public partial class CONEXION_MANUAL : System.Windows.Forms.Form
    {
        //Form reemplaza a hide para limpiar la lista de componentes.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONEXION_MANUAL));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtdatasource = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCnString = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.GenerarConexionWeb = new System.Windows.Forms.Button();
            this.MostrarConexionWeb = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCnStringWEB = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Logo_empresa = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.datalistado_movimientos_validar = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_movimientos_validar)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 17);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Servidor";
            // 
            // txtdatasource
            // 
            this.txtdatasource.Location = new System.Drawing.Point(95, 14);
            this.txtdatasource.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatasource.Name = "txtdatasource";
            this.txtdatasource.Size = new System.Drawing.Size(479, 22);
            this.txtdatasource.TabIndex = 1;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(96, 49);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(479, 41);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Conectar";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Location = new System.Drawing.Point(25, 46);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(13, 12);
            this.GroupBox1.TabIndex = 35;
            this.GroupBox1.TabStop = false;
            // 
            // txtCnString
            // 
            this.txtCnString.BackColor = System.Drawing.Color.White;
            this.txtCnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnString.Location = new System.Drawing.Point(63, 113);
            this.txtCnString.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnString.Multiline = true;
            this.txtCnString.Name = "txtCnString";
            this.txtCnString.Size = new System.Drawing.Size(838, 100);
            this.txtCnString.TabIndex = 25;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Label3.Location = new System.Drawing.Point(64, 37);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(500, 23);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Ingrese la cadena de conexion LOCAL\r\n";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(63)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageKey = "disk.png";
            this.btnSave.Location = new System.Drawing.Point(68, 230);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(296, 34);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Generar cadena de conexion";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageKey = "cross.png";
            this.btnReset.Location = new System.Drawing.Point(-64, 46);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(500, 34);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtdatasource);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.btnReset);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Location = new System.Drawing.Point(39, 52);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(13, 12);
            this.Panel1.TabIndex = 28;
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.BackColor = System.Drawing.Color.White;
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.Color.Black;
            this.Cerrar.Location = new System.Drawing.Point(897, 2);
            this.Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(36, 31);
            this.Cerrar.TabIndex = 546;
            this.Cerrar.Text = "X";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label2.Location = new System.Drawing.Point(60, 60);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(599, 49);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Una vez que estes listo dale a \"Generar cadena de conexion\", se creara un Archivo" +
    " que contendra\r\ntu conexion Encryptada. Ahora tu conexion es mas Segura ante Pos" +
    "ibles hackers";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerarConexionWeb
            // 
            this.GenerarConexionWeb.BackColor = System.Drawing.Color.Gold;
            this.GenerarConexionWeb.FlatAppearance.BorderSize = 0;
            this.GenerarConexionWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerarConexionWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.GenerarConexionWeb.ForeColor = System.Drawing.Color.Black;
            this.GenerarConexionWeb.Location = new System.Drawing.Point(68, 503);
            this.GenerarConexionWeb.Margin = new System.Windows.Forms.Padding(4);
            this.GenerarConexionWeb.Name = "GenerarConexionWeb";
            this.GenerarConexionWeb.Size = new System.Drawing.Size(287, 34);
            this.GenerarConexionWeb.TabIndex = 547;
            this.GenerarConexionWeb.Text = "Generar Conexion Web";
            this.GenerarConexionWeb.UseVisualStyleBackColor = false;
            this.GenerarConexionWeb.Click += new System.EventHandler(this.GenerarConexionWeb_Click);
            // 
            // MostrarConexionWeb
            // 
            this.MostrarConexionWeb.BackColor = System.Drawing.Color.White;
            this.MostrarConexionWeb.FlatAppearance.BorderSize = 0;
            this.MostrarConexionWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarConexionWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MostrarConexionWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MostrarConexionWeb.Location = new System.Drawing.Point(379, 503);
            this.MostrarConexionWeb.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarConexionWeb.Name = "MostrarConexionWeb";
            this.MostrarConexionWeb.Size = new System.Drawing.Size(296, 34);
            this.MostrarConexionWeb.TabIndex = 547;
            this.MostrarConexionWeb.Text = "Mostrar Conexion Web";
            this.MostrarConexionWeb.UseVisualStyleBackColor = false;
            this.MostrarConexionWeb.Click += new System.EventHandler(this.MostrarConexionWeb_Click);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Tahoma", 7F);
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label4.Location = new System.Drawing.Point(60, 345);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(599, 49);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Una vez que estes listo dale a \"Generar cadena de conexion\", se creara un Archivo" +
    " que contendra\r\ntu conexion Encryptada. Ahora tu conexion es mas Segura ante Pos" +
    "ibles hackers";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Label5.Location = new System.Drawing.Point(64, 321);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(500, 23);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "Ingrese la cadena de conexion WEB";
            // 
            // txtCnStringWEB
            // 
            this.txtCnStringWEB.BackColor = System.Drawing.Color.White;
            this.txtCnStringWEB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnStringWEB.Location = new System.Drawing.Point(68, 395);
            this.txtCnStringWEB.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnStringWEB.Multiline = true;
            this.txtCnStringWEB.Name = "txtCnStringWEB";
            this.txtCnStringWEB.Size = new System.Drawing.Size(838, 100);
            this.txtCnStringWEB.TabIndex = 25;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DimGray;
            this.Panel2.Location = new System.Drawing.Point(67, 290);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(839, 1);
            this.Panel2.TabIndex = 548;
            // 
            // Logo_empresa
            // 
            this.Logo_empresa.BackColor = System.Drawing.Color.White;
            this.Logo_empresa.Image = ((System.Drawing.Image)(resources.GetObject("Logo_empresa.Image")));
            this.Logo_empresa.Location = new System.Drawing.Point(821, 37);
            this.Logo_empresa.Margin = new System.Windows.Forms.Padding(4);
            this.Logo_empresa.Name = "Logo_empresa";
            this.Logo_empresa.Size = new System.Drawing.Size(84, 66);
            this.Logo_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_empresa.TabIndex = 589;
            this.Logo_empresa.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(821, 321);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(84, 66);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 589;
            this.PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // datalistado_movimientos_validar
            // 
            this.datalistado_movimientos_validar.AllowUserToAddRows = false;
            this.datalistado_movimientos_validar.AllowUserToDeleteRows = false;
            this.datalistado_movimientos_validar.AllowUserToResizeRows = false;
            this.datalistado_movimientos_validar.BackgroundColor = System.Drawing.Color.White;
            this.datalistado_movimientos_validar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado_movimientos_validar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistado_movimientos_validar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado_movimientos_validar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datalistado_movimientos_validar.DefaultCellStyle = dataGridViewCellStyle2;
            this.datalistado_movimientos_validar.Location = new System.Drawing.Point(447, 119);
            this.datalistado_movimientos_validar.Margin = new System.Windows.Forms.Padding(4);
            this.datalistado_movimientos_validar.Name = "datalistado_movimientos_validar";
            this.datalistado_movimientos_validar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado_movimientos_validar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datalistado_movimientos_validar.RowHeadersVisible = false;
            this.datalistado_movimientos_validar.RowHeadersWidth = 5;
            this.datalistado_movimientos_validar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.datalistado_movimientos_validar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado_movimientos_validar.Size = new System.Drawing.Size(117, 54);
            this.datalistado_movimientos_validar.TabIndex = 590;
            // 
            // DataGridViewCheckBoxColumn5
            // 
            this.DataGridViewCheckBoxColumn5.DataPropertyName = "Activo";
            this.DataGridViewCheckBoxColumn5.HeaderText = "Activo";
            this.DataGridViewCheckBoxColumn5.MinimumWidth = 6;
            this.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5";
            this.DataGridViewCheckBoxColumn5.ReadOnly = true;
            this.DataGridViewCheckBoxColumn5.Width = 125;
            // 
            // CONEXION_MANUAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 574);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Logo_empresa);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.GenerarConexionWeb);
            this.Controls.Add(this.MostrarConexionWeb);
            this.Controls.Add(this.txtCnStringWEB);
            this.Controls.Add(this.txtCnString);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.datalistado_movimientos_validar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CONEXION_MANUAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONEXION_MANUAL";
            this.Load += new System.EventHandler(this.CONEXION_MANUAL_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_movimientos_validar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtdatasource;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtCnString;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button Cerrar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button GenerarConexionWeb;
        internal System.Windows.Forms.Button MostrarConexionWeb;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCnStringWEB;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.PictureBox Logo_empresa;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.DataGridView datalistado_movimientos_validar;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn5;
        internal Timer Timer2;
    }

}