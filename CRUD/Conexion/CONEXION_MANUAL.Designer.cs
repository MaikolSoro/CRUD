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
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtdatasource = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCnString = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)this.Logo_empresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.datalistado_movimientos_validar).BeginInit();
            this.SuspendLayout();
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Servidor";
            //
            //txtdatasource
            //
            this.txtdatasource.Location = new System.Drawing.Point(71, 11);
            this.txtdatasource.Name = "txtdatasource";
            this.txtdatasource.Size = new System.Drawing.Size(360, 20);
            this.txtdatasource.TabIndex = 1;
            //
            //Button1
            //
            this.Button1.Location = new System.Drawing.Point(72, 40);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(359, 33);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Conectar";
            this.Button1.UseVisualStyleBackColor = true;
            //
            //GroupBox1
            //
            this.GroupBox1.Location = new System.Drawing.Point(19, 37);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(10, 10);
            this.GroupBox1.TabIndex = 35;
            this.GroupBox1.TabStop = false;
            //
            //txtCnString
            //
            this.txtCnString.BackColor = System.Drawing.Color.White;
            this.txtCnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnString.Location = new System.Drawing.Point(47, 92);
            this.txtCnString.Multiline = true;
            this.txtCnString.Name = "txtCnString";
            this.txtCnString.Size = new System.Drawing.Size(629, 82);
            this.txtCnString.TabIndex = 25;
            //
            //Label3
            //
            this.Label3.Font = new System.Drawing.Font("Tahoma", 11.0F, System.Drawing.FontStyle.Bold);
            this.Label3.Location = new System.Drawing.Point(48, 30);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(375, 19);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Ingrese la cadena de conexion LOCAL" + "\r" + "\n";
            //
            //btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)166), (int)((byte)63));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageKey = "disk.png";
            this.btnSave.Location = new System.Drawing.Point(51, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 28);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Generar cadena de conexion";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            //
            //btnReset
            //
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.btnReset.ImageKey = "cross.png";
            this.btnReset.Location = new System.Drawing.Point(-48, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(375, 28);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            //
            //Panel1
            //
            this.Panel1.Controls.Add(this.txtdatasource);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.btnReset);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Location = new System.Drawing.Point(29, 42);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(10, 10);
            this.Panel1.TabIndex = 28;
            //
            //Button2
            //
            this.Button2.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.Button2.BackColor = System.Drawing.Color.White;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb((int)((byte)224), (int)((byte)224), (int)((byte)224));
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(673, 2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(27, 25);
            this.Button2.TabIndex = 546;
            this.Button2.Text = "X";
            this.Button2.UseVisualStyleBackColor = false;
            //
            //Label2
            //
            this.Label2.Font = new System.Drawing.Font("Tahoma", 7.0F);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label2.Location = new System.Drawing.Point(45, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(449, 40);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Una vez que estes listo dale a \"Generar cadena de conexion\", se creara un Archivo" + " que contendra" + "\r" + "\n" + "tu conexion Encryptada. Ahora tu conexion es mas Segura ante Pos" + "ibles hackers";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Button3
            //
            this.Button3.BackColor = System.Drawing.Color.Gold;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0F, System.Drawing.FontStyle.Bold);
            this.Button3.ForeColor = System.Drawing.Color.Black;
            this.Button3.Location = new System.Drawing.Point(51, 409);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(215, 28);
            this.Button3.TabIndex = 547;
            this.Button3.Text = "Generar Conexion Web";
            this.Button3.UseVisualStyleBackColor = false;
            //
            //Button5
            //
            this.Button5.BackColor = System.Drawing.Color.White;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0F);
            this.Button5.ForeColor = System.Drawing.Color.FromArgb((int)((byte)64), (int)((byte)64), (int)((byte)64));
            this.Button5.Location = new System.Drawing.Point(284, 409);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(222, 28);
            this.Button5.TabIndex = 547;
            this.Button5.Text = "Mostrar Conexion Web";
            this.Button5.UseVisualStyleBackColor = false;
            //
            //Label4
            //
            this.Label4.Font = new System.Drawing.Font("Tahoma", 7.0F);
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label4.Location = new System.Drawing.Point(45, 280);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(449, 40);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Una vez que estes listo dale a \"Generar cadena de conexion\", se creara un Archivo" + " que contendra" + "\r" + "\n" + "tu conexion Encryptada. Ahora tu conexion es mas Segura ante Pos" + "ibles hackers";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label5
            //
            this.Label5.Font = new System.Drawing.Font("Tahoma", 11.0F, System.Drawing.FontStyle.Bold);
            this.Label5.Location = new System.Drawing.Point(48, 261);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(375, 19);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "Ingrese la cadena de conexion WEB";
            //
            //txtCnStringWEB
            //
            this.txtCnStringWEB.BackColor = System.Drawing.Color.White;
            this.txtCnStringWEB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnStringWEB.Location = new System.Drawing.Point(51, 321);
            this.txtCnStringWEB.Multiline = true;
            this.txtCnStringWEB.Name = "txtCnStringWEB";
            this.txtCnStringWEB.Size = new System.Drawing.Size(629, 82);
            this.txtCnStringWEB.TabIndex = 25;
            //
            //Panel2
            //
            this.Panel2.BackColor = System.Drawing.Color.DimGray;
            this.Panel2.Location = new System.Drawing.Point(50, 236);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(629, 1);
            this.Panel2.TabIndex = 548;
            //
            //Logo_empresa
            //
            this.Logo_empresa.BackColor = System.Drawing.Color.White;
            this.Logo_empresa.Image = (System.Drawing.Image)resources.GetObject("Logo_empresa.Image");
            this.Logo_empresa.Location = new System.Drawing.Point(616, 30);
            this.Logo_empresa.Name = "Logo_empresa";
            this.Logo_empresa.Size = new System.Drawing.Size(63, 54);
            this.Logo_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_empresa.TabIndex = 589;
            this.Logo_empresa.TabStop = false;
            //
            //PictureBox1
            //
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
            this.PictureBox1.Location = new System.Drawing.Point(616, 261);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(63, 54);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 589;
            this.PictureBox1.TabStop = false;
            //
            //Timer1
            //
            //
            //datalistado_movimientos_validar
            //
            this.datalistado_movimientos_validar.AllowUserToAddRows = false;
            this.datalistado_movimientos_validar.AllowUserToDeleteRows = false;
            this.datalistado_movimientos_validar.AllowUserToResizeRows = false;
            this.datalistado_movimientos_validar.BackgroundColor = System.Drawing.Color.White;
            this.datalistado_movimientos_validar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado_movimientos_validar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            this.datalistado_movimientos_validar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado_movimientos_validar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.DataGridViewCheckBoxColumn5 });
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datalistado_movimientos_validar.DefaultCellStyle = DataGridViewCellStyle2;
            this.datalistado_movimientos_validar.Location = new System.Drawing.Point(335, 97);
            this.datalistado_movimientos_validar.Name = "datalistado_movimientos_validar";
            this.datalistado_movimientos_validar.ReadOnly = true;
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado_movimientos_validar.RowHeadersDefaultCellStyle = DataGridViewCellStyle3;
            this.datalistado_movimientos_validar.RowHeadersVisible = false;
            this.datalistado_movimientos_validar.RowHeadersWidth = 5;
            this.datalistado_movimientos_validar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.datalistado_movimientos_validar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado_movimientos_validar.Size = new System.Drawing.Size(88, 44);
            this.datalistado_movimientos_validar.TabIndex = 590;
            //
            //DataGridViewCheckBoxColumn5
            //
            this.DataGridViewCheckBoxColumn5.DataPropertyName = "Activo";
            this.DataGridViewCheckBoxColumn5.HeaderText = "Activo";
            this.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5";
            this.DataGridViewCheckBoxColumn5.ReadOnly = true;
            //
            //Timer2
            //
            //
            //CONEXION_MANUAL
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 466);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Logo_empresa);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.txtCnStringWEB);
            this.Controls.Add(this.txtCnString);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.datalistado_movimientos_validar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CONEXION_MANUAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONEXION_MANUAL";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.Logo_empresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.datalistado_movimientos_validar).EndInit();
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
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button5;
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