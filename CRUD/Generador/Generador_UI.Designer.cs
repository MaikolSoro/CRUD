using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.IO;
using System.Threading;
using System.Management;

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
	public partial class Generador_UI : System.Windows.Forms.Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generador_UI));
            this.datalistado_TABLAS = new System.Windows.Forms.DataGridView();
            this.Tablas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel11 = new System.Windows.Forms.Panel();
            this.datalistadoEstructura = new System.Windows.Forms.DataGridView();
            this.Parametros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enumeracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCrear_procedimientos = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtcontador = new System.Windows.Forms.TextBox();
            this.labelComillas = new System.Windows.Forms.Label();
            this.txtCrudSQLCompleto = new System.Windows.Forms.RichTextBox();
            this.txtbasededatos = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtInsertarSQLServer = new System.Windows.Forms.RichTextBox();
            this.txtEditar = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.RichTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PanelVb = new System.Windows.Forms.Panel();
            this.Panel20 = new System.Windows.Forms.Panel();
            this.Button20 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtMostrarVb = new System.Windows.Forms.RichTextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Panel22 = new System.Windows.Forms.Panel();
            this.Button22 = new System.Windows.Forms.Button();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtEditarVb = new System.Windows.Forms.RichTextBox();
            this.Panel23 = new System.Windows.Forms.Panel();
            this.Button21 = new System.Windows.Forms.Button();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtInsertarVb = new System.Windows.Forms.RichTextBox();
            this.PanelCsharp = new System.Windows.Forms.Panel();
            this.Panelmostrar = new System.Windows.Forms.Panel();
            this.txtMostrarCsharp = new System.Windows.Forms.RichTextBox();
            this.Panel27 = new System.Windows.Forms.Panel();
            this.PanelParametros = new System.Windows.Forms.Panel();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.datalistadoEstructuraCONParametros = new System.Windows.Forms.DataGridView();
            this.Parametros2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enumeracion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Label12 = new System.Windows.Forms.Label();
            this.ConParametrosCsharp = new System.Windows.Forms.CheckBox();
            this.Button23 = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.PanelEditar = new System.Windows.Forms.Panel();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.Button25 = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtEditarCsharp = new System.Windows.Forms.RichTextBox();
            this.PanelInsertar = new System.Windows.Forms.Panel();
            this.Button24 = new System.Windows.Forms.Button();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtInsertarCsharp = new System.Windows.Forms.RichTextBox();
            this.PanelSQLServer = new System.Windows.Forms.Panel();
            this.Panel18 = new System.Windows.Forms.Panel();
            this.StatusStrip5 = new System.Windows.Forms.StatusStrip();
            this.ToolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.Label21 = new System.Windows.Forms.Label();
            this.Panel17 = new System.Windows.Forms.Panel();
            this.StatusStrip4 = new System.Windows.Forms.StatusStrip();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.Label9 = new System.Windows.Forms.Label();
            this.Panel16 = new System.Windows.Forms.Panel();
            this.StatusStrip3 = new System.Windows.Forms.StatusStrip();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.Label7 = new System.Windows.Forms.Label();
            this.Button16 = new System.Windows.Forms.Button();
            this.Button15 = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.PanelVerInsertarSQLserver = new System.Windows.Forms.Panel();
            this.StatusStrip2 = new System.Windows.Forms.StatusStrip();
            this.TSQLver = new System.Windows.Forms.ToolStripButton();
            this.TSQLvolver = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.PanelRepeticiones = new System.Windows.Forms.Panel();
            this.Label17 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblRepeticionesSQLServer1 = new System.Windows.Forms.Label();
            this.txtErrorSQLServer = new System.Windows.Forms.RichTextBox();
            this.lblRepeticionesSQLServer2 = new System.Windows.Forms.RichTextBox();
            this.EvitarRepeticionesSQLServer = new System.Windows.Forms.CheckBox();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button12 = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.RichTextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Button13 = new System.Windows.Forms.Button();
            this.Button14 = new System.Windows.Forms.Button();
            this.PanelTABLET = new System.Windows.Forms.Panel();
            this.Panel25 = new System.Windows.Forms.Panel();
            this.Button18 = new System.Windows.Forms.Button();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.Button6 = new System.Windows.Forms.Button();
            this.Panel14 = new System.Windows.Forms.Panel();
            this.Button5 = new System.Windows.Forms.Button();
            this.Panel13 = new System.Windows.Forms.Panel();
            this.Button4 = new System.Windows.Forms.Button();
            this.Panel12 = new System.Windows.Forms.Panel();
            this.btnCsharp = new System.Windows.Forms.Button();
            this.Panel10 = new System.Windows.Forms.Panel();
            this.btnVb = new System.Windows.Forms.Button();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.btnSQLSERVER = new System.Windows.Forms.Button();
            this.Panel15 = new System.Windows.Forms.Panel();
            this.PanelBienvenida = new System.Windows.Forms.Panel();
            this.Label15 = new System.Windows.Forms.Label();
            this.PanelMvvcCsharp = new System.Windows.Forms.Panel();
            this.txtModeloCsharp = new System.Windows.Forms.RichTextBox();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Panel19 = new System.Windows.Forms.Panel();
            this.Panel28 = new System.Windows.Forms.Panel();
            this.Panel30 = new System.Windows.Forms.Panel();
            this.VerCodigo = new System.Windows.Forms.Button();
            this.Panel34 = new System.Windows.Forms.Panel();
            this.Label22 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button17 = new System.Windows.Forms.Button();
            this.Panel32 = new System.Windows.Forms.Panel();
            this.Panel26 = new System.Windows.Forms.Panel();
            this.StatusStrip6 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AcercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel37 = new System.Windows.Forms.Panel();
            this.Panel29 = new System.Windows.Forms.Panel();
            this.Label20 = new System.Windows.Forms.Label();
            this.Panel21 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel24 = new System.Windows.Forms.Panel();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel31 = new System.Windows.Forms.Panel();
            this.Panel35 = new System.Windows.Forms.Panel();
            this.Panel36 = new System.Windows.Forms.Panel();
            this.Panel33 = new System.Windows.Forms.Panel();
            this.Panel38 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_TABLAS)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoEstructura)).BeginInit();
            this.Panel2.SuspendLayout();
            this.PanelVb.SuspendLayout();
            this.Panel20.SuspendLayout();
            this.Panel22.SuspendLayout();
            this.Panel23.SuspendLayout();
            this.PanelCsharp.SuspendLayout();
            this.Panelmostrar.SuspendLayout();
            this.Panel27.SuspendLayout();
            this.PanelParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoEstructuraCONParametros)).BeginInit();
            this.PanelEditar.SuspendLayout();
            this.PanelInsertar.SuspendLayout();
            this.PanelSQLServer.SuspendLayout();
            this.Panel18.SuspendLayout();
            this.StatusStrip5.SuspendLayout();
            this.Panel17.SuspendLayout();
            this.StatusStrip4.SuspendLayout();
            this.Panel16.SuspendLayout();
            this.StatusStrip3.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.PanelVerInsertarSQLserver.SuspendLayout();
            this.StatusStrip2.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.PanelRepeticiones.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.PanelTABLET.SuspendLayout();
            this.Panel25.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel14.SuspendLayout();
            this.Panel13.SuspendLayout();
            this.Panel12.SuspendLayout();
            this.Panel10.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.PanelBienvenida.SuspendLayout();
            this.PanelMvvcCsharp.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel28.SuspendLayout();
            this.Panel30.SuspendLayout();
            this.Panel34.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.Panel26.SuspendLayout();
            this.StatusStrip6.SuspendLayout();
            this.Panel29.SuspendLayout();
            this.Panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // datalistado_TABLAS
            // 
            this.datalistado_TABLAS.AllowUserToAddRows = false;
            this.datalistado_TABLAS.AllowUserToDeleteRows = false;
            this.datalistado_TABLAS.AllowUserToResizeRows = false;
            this.datalistado_TABLAS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.datalistado_TABLAS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado_TABLAS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistado_TABLAS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistado_TABLAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado_TABLAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tablas});
            this.datalistado_TABLAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalistado_TABLAS.GridColor = System.Drawing.Color.DimGray;
            this.datalistado_TABLAS.Location = new System.Drawing.Point(0, 63);
            this.datalistado_TABLAS.Name = "datalistado_TABLAS";
            this.datalistado_TABLAS.ReadOnly = true;
            this.datalistado_TABLAS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistado_TABLAS.RowHeadersVisible = false;
            this.datalistado_TABLAS.RowHeadersWidth = 51;
            this.datalistado_TABLAS.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.datalistado_TABLAS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.datalistado_TABLAS.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.datalistado_TABLAS.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datalistado_TABLAS.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datalistado_TABLAS.RowTemplate.Height = 40;
            this.datalistado_TABLAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado_TABLAS.Size = new System.Drawing.Size(344, 527);
            this.datalistado_TABLAS.TabIndex = 1;
            // 
            // Tablas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Tablas.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tablas.HeaderText = "Tablas";
            this.Tablas.MinimumWidth = 6;
            this.Tablas.Name = "Tablas";
            this.Tablas.ReadOnly = true;
            this.Tablas.Width = 125;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Panel11);
            this.Panel1.Controls.Add(this.txtbasededatos);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(344, 63);
            this.Panel1.TabIndex = 13;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(3, 6);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(120, 23);
            this.Label5.TabIndex = 17;
            this.Label5.Text = "Base de datos";
            // 
            // Panel11
            // 
            this.Panel11.Controls.Add(this.datalistadoEstructura);
            this.Panel11.Controls.Add(this.txtCrear_procedimientos);
            this.Panel11.Controls.Add(this.txtID);
            this.Panel11.Controls.Add(this.txtcontador);
            this.Panel11.Controls.Add(this.labelComillas);
            this.Panel11.Controls.Add(this.txtCrudSQLCompleto);
            this.Panel11.Location = new System.Drawing.Point(236, 10);
            this.Panel11.Name = "Panel11";
            this.Panel11.Size = new System.Drawing.Size(10, 10);
            this.Panel11.TabIndex = 16;
            // 
            // datalistadoEstructura
            // 
            this.datalistadoEstructura.AllowUserToAddRows = false;
            this.datalistadoEstructura.AllowUserToDeleteRows = false;
            this.datalistadoEstructura.AllowUserToResizeRows = false;
            this.datalistadoEstructura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.datalistadoEstructura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistadoEstructura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datalistadoEstructura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistadoEstructura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoEstructura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parametros,
            this.Tipo,
            this.Longitud,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Enumeracion,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.datalistadoEstructura.GridColor = System.Drawing.Color.DimGray;
            this.datalistadoEstructura.Location = new System.Drawing.Point(32, 8);
            this.datalistadoEstructura.Name = "datalistadoEstructura";
            this.datalistadoEstructura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistadoEstructura.RowHeadersVisible = false;
            this.datalistadoEstructura.RowHeadersWidth = 51;
            this.datalistadoEstructura.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.datalistadoEstructura.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.datalistadoEstructura.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.datalistadoEstructura.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datalistadoEstructura.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datalistadoEstructura.RowTemplate.Height = 40;
            this.datalistadoEstructura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoEstructura.Size = new System.Drawing.Size(34, 57);
            this.datalistadoEstructura.TabIndex = 14;
            // 
            // Parametros
            // 
            this.Parametros.HeaderText = "Parametros";
            this.Parametros.MinimumWidth = 6;
            this.Parametros.Name = "Parametros";
            this.Parametros.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Longitud
            // 
            this.Longitud.HeaderText = "Longitud";
            this.Longitud.MinimumWidth = 6;
            this.Longitud.Name = "Longitud";
            this.Longitud.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Enumeracion
            // 
            this.Enumeracion.HeaderText = "Enumeracion";
            this.Enumeracion.MinimumWidth = 6;
            this.Enumeracion.Name = "Enumeracion";
            this.Enumeracion.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Column14";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Column16";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.Width = 125;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Column17";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.Width = 125;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Column18";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.Width = 125;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Column19";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.Width = 125;
            // 
            // txtCrear_procedimientos
            // 
            this.txtCrear_procedimientos.Location = new System.Drawing.Point(20, 52);
            this.txtCrear_procedimientos.Name = "txtCrear_procedimientos";
            this.txtCrear_procedimientos.Size = new System.Drawing.Size(231, 219);
            this.txtCrear_procedimientos.TabIndex = 30;
            this.txtCrear_procedimientos.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(27, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 23);
            this.txtID.TabIndex = 31;
            // 
            // txtcontador
            // 
            this.txtcontador.Location = new System.Drawing.Point(29, 35);
            this.txtcontador.Name = "txtcontador";
            this.txtcontador.Size = new System.Drawing.Size(72, 23);
            this.txtcontador.TabIndex = 17;
            // 
            // labelComillas
            // 
            this.labelComillas.AutoSize = true;
            this.labelComillas.ForeColor = System.Drawing.Color.White;
            this.labelComillas.Location = new System.Drawing.Point(59, 3);
            this.labelComillas.Name = "labelComillas";
            this.labelComillas.Size = new System.Drawing.Size(13, 18);
            this.labelComillas.TabIndex = 20;
            this.labelComillas.Text = "\"";
            // 
            // txtCrudSQLCompleto
            // 
            this.txtCrudSQLCompleto.Location = new System.Drawing.Point(-20, 29);
            this.txtCrudSQLCompleto.Name = "txtCrudSQLCompleto";
            this.txtCrudSQLCompleto.Size = new System.Drawing.Size(161, 36);
            this.txtCrudSQLCompleto.TabIndex = 30;
            this.txtCrudSQLCompleto.Text = "";
            // 
            // txtbasededatos
            // 
            this.txtbasededatos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbasededatos.FormattingEnabled = true;
            this.txtbasededatos.Location = new System.Drawing.Point(6, 29);
            this.txtbasededatos.Name = "txtbasededatos";
            this.txtbasededatos.Size = new System.Drawing.Size(204, 31);
            this.txtbasededatos.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(3, 14);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(135, 37);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Insertar";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInsertarSQLServer
            // 
            this.txtInsertarSQLServer.BackColor = System.Drawing.Color.Black;
            this.txtInsertarSQLServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsertarSQLServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInsertarSQLServer.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtInsertarSQLServer.ForeColor = System.Drawing.Color.White;
            this.txtInsertarSQLServer.Location = new System.Drawing.Point(0, 0);
            this.txtInsertarSQLServer.Name = "txtInsertarSQLServer";
            this.txtInsertarSQLServer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInsertarSQLServer.Size = new System.Drawing.Size(37, 33);
            this.txtInsertarSQLServer.TabIndex = 11;
            this.txtInsertarSQLServer.Text = "";
            // 
            // txtEditar
            // 
            this.txtEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEditar.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtEditar.ForeColor = System.Drawing.Color.White;
            this.txtEditar.Location = new System.Drawing.Point(0, 89);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtEditar.Size = new System.Drawing.Size(357, 204);
            this.txtEditar.TabIndex = 14;
            this.txtEditar.Text = "";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(6, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 40);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Editar";
            // 
            // txtMostrar
            // 
            this.txtMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMostrar.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtMostrar.ForeColor = System.Drawing.Color.White;
            this.txtMostrar.Location = new System.Drawing.Point(7, 63);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMostrar.Size = new System.Drawing.Size(346, 110);
            this.txtMostrar.TabIndex = 17;
            this.txtMostrar.Text = "";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(3, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(150, 40);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Mostrar";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panel2.Controls.Add(this.PanelVb);
            this.Panel2.Controls.Add(this.PanelCsharp);
            this.Panel2.Controls.Add(this.PanelSQLServer);
            this.Panel2.Controls.Add(this.PanelTABLET);
            this.Panel2.Controls.Add(this.PanelBienvenida);
            this.Panel2.Controls.Add(this.PanelMvvcCsharp);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel2.Location = new System.Drawing.Point(380, 114);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(968, 619);
            this.Panel2.TabIndex = 3;
            // 
            // PanelVb
            // 
            this.PanelVb.Controls.Add(this.Panel20);
            this.PanelVb.Controls.Add(this.Panel22);
            this.PanelVb.Controls.Add(this.Panel23);
            this.PanelVb.Location = new System.Drawing.Point(838, 178);
            this.PanelVb.Name = "PanelVb";
            this.PanelVb.Size = new System.Drawing.Size(90, 357);
            this.PanelVb.TabIndex = 33;
            this.PanelVb.Visible = false;
            // 
            // Panel20
            // 
            this.Panel20.Controls.Add(this.Button20);
            this.Panel20.Controls.Add(this.Label4);
            this.Panel20.Controls.Add(this.txtMostrarVb);
            this.Panel20.Controls.Add(this.Label16);
            this.Panel20.Location = new System.Drawing.Point(9, 8);
            this.Panel20.Name = "Panel20";
            this.Panel20.Size = new System.Drawing.Size(360, 310);
            this.Panel20.TabIndex = 47;
            // 
            // Button20
            // 
            this.Button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button20.FlatAppearance.BorderSize = 0;
            this.Button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button20.Location = new System.Drawing.Point(256, 33);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(94, 44);
            this.Button20.TabIndex = 39;
            this.Button20.Text = "Copiar";
            this.Button20.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(8, 48);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(150, 40);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Mostrar";
            // 
            // txtMostrarVb
            // 
            this.txtMostrarVb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMostrarVb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMostrarVb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMostrarVb.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtMostrarVb.ForeColor = System.Drawing.Color.White;
            this.txtMostrarVb.Location = new System.Drawing.Point(0, 84);
            this.txtMostrarVb.Name = "txtMostrarVb";
            this.txtMostrarVb.ReadOnly = true;
            this.txtMostrarVb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMostrarVb.Size = new System.Drawing.Size(360, 226);
            this.txtMostrarVb.TabIndex = 11;
            this.txtMostrarVb.Text = "";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(10, 18);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(207, 28);
            this.Label16.TabIndex = 38;
            this.Label16.Text = "En DatagridView";
            // 
            // Panel22
            // 
            this.Panel22.Controls.Add(this.Button22);
            this.Panel22.Controls.Add(this.Label18);
            this.Panel22.Controls.Add(this.txtEditarVb);
            this.Panel22.Location = new System.Drawing.Point(9, 323);
            this.Panel22.Name = "Panel22";
            this.Panel22.Size = new System.Drawing.Size(356, 174);
            this.Panel22.TabIndex = 46;
            // 
            // Button22
            // 
            this.Button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button22.FlatAppearance.BorderSize = 0;
            this.Button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button22.Location = new System.Drawing.Point(257, 16);
            this.Button22.Name = "Button22";
            this.Button22.Size = new System.Drawing.Size(94, 44);
            this.Button22.TabIndex = 28;
            this.Button22.Text = "Copiar";
            this.Button22.UseVisualStyleBackColor = false;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.Label18.ForeColor = System.Drawing.Color.White;
            this.Label18.Location = new System.Drawing.Point(3, 23);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(131, 40);
            this.Label18.TabIndex = 9;
            this.Label18.Text = "Editar";
            // 
            // txtEditarVb
            // 
            this.txtEditarVb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEditarVb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditarVb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEditarVb.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtEditarVb.ForeColor = System.Drawing.Color.White;
            this.txtEditarVb.Location = new System.Drawing.Point(0, 67);
            this.txtEditarVb.Name = "txtEditarVb";
            this.txtEditarVb.ReadOnly = true;
            this.txtEditarVb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtEditarVb.Size = new System.Drawing.Size(356, 107);
            this.txtEditarVb.TabIndex = 11;
            this.txtEditarVb.Text = "";
            // 
            // Panel23
            // 
            this.Panel23.Controls.Add(this.Button21);
            this.Panel23.Controls.Add(this.Label19);
            this.Panel23.Controls.Add(this.txtInsertarVb);
            this.Panel23.Location = new System.Drawing.Point(381, 8);
            this.Panel23.Name = "Panel23";
            this.Panel23.Size = new System.Drawing.Size(356, 310);
            this.Panel23.TabIndex = 44;
            // 
            // Button21
            // 
            this.Button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button21.FlatAppearance.BorderSize = 0;
            this.Button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button21.Location = new System.Drawing.Point(255, 33);
            this.Button21.Name = "Button21";
            this.Button21.Size = new System.Drawing.Size(94, 44);
            this.Button21.TabIndex = 28;
            this.Button21.Text = "Copiar";
            this.Button21.UseVisualStyleBackColor = false;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.Label19.ForeColor = System.Drawing.Color.White;
            this.Label19.Location = new System.Drawing.Point(3, 40);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(169, 40);
            this.Label19.TabIndex = 9;
            this.Label19.Text = "Insertar";
            // 
            // txtInsertarVb
            // 
            this.txtInsertarVb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtInsertarVb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsertarVb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInsertarVb.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtInsertarVb.ForeColor = System.Drawing.Color.White;
            this.txtInsertarVb.Location = new System.Drawing.Point(0, 84);
            this.txtInsertarVb.Name = "txtInsertarVb";
            this.txtInsertarVb.ReadOnly = true;
            this.txtInsertarVb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInsertarVb.Size = new System.Drawing.Size(356, 226);
            this.txtInsertarVb.TabIndex = 11;
            this.txtInsertarVb.Text = "";
            // 
            // PanelCsharp
            // 
            this.PanelCsharp.Controls.Add(this.Panelmostrar);
            this.PanelCsharp.Controls.Add(this.PanelEditar);
            this.PanelCsharp.Controls.Add(this.PanelInsertar);
            this.PanelCsharp.Location = new System.Drawing.Point(918, 89);
            this.PanelCsharp.Name = "PanelCsharp";
            this.PanelCsharp.Size = new System.Drawing.Size(127, 636);
            this.PanelCsharp.TabIndex = 31;
            this.PanelCsharp.Visible = false;
            // 
            // Panelmostrar
            // 
            this.Panelmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panelmostrar.Controls.Add(this.txtMostrarCsharp);
            this.Panelmostrar.Controls.Add(this.Panel27);
            this.Panelmostrar.Controls.Add(this.Button23);
            this.Panelmostrar.Controls.Add(this.Label8);
            this.Panelmostrar.Controls.Add(this.Label11);
            this.Panelmostrar.Location = new System.Drawing.Point(9, 8);
            this.Panelmostrar.Name = "Panelmostrar";
            this.Panelmostrar.Size = new System.Drawing.Size(360, 328);
            this.Panelmostrar.TabIndex = 47;
            // 
            // txtMostrarCsharp
            // 
            this.txtMostrarCsharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMostrarCsharp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMostrarCsharp.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtMostrarCsharp.ForeColor = System.Drawing.Color.White;
            this.txtMostrarCsharp.Location = new System.Drawing.Point(6, 94);
            this.txtMostrarCsharp.Name = "txtMostrarCsharp";
            this.txtMostrarCsharp.ReadOnly = true;
            this.txtMostrarCsharp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMostrarCsharp.Size = new System.Drawing.Size(349, 225);
            this.txtMostrarCsharp.TabIndex = 11;
            this.txtMostrarCsharp.Text = "";
            // 
            // Panel27
            // 
            this.Panel27.Controls.Add(this.PanelParametros);
            this.Panel27.Location = new System.Drawing.Point(236, 33);
            this.Panel27.Name = "Panel27";
            this.Panel27.Size = new System.Drawing.Size(10, 10);
            this.Panel27.TabIndex = 41;
            // 
            // PanelParametros
            // 
            this.PanelParametros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.PanelParametros.Controls.Add(this.CheckBox3);
            this.PanelParametros.Controls.Add(this.datalistadoEstructuraCONParametros);
            this.PanelParametros.Controls.Add(this.Label12);
            this.PanelParametros.Controls.Add(this.ConParametrosCsharp);
            this.PanelParametros.Location = new System.Drawing.Point(23, 26);
            this.PanelParametros.Name = "PanelParametros";
            this.PanelParametros.Size = new System.Drawing.Size(28, 50);
            this.PanelParametros.TabIndex = 40;
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Font = new System.Drawing.Font("Consolas", 10F);
            this.CheckBox3.ForeColor = System.Drawing.Color.White;
            this.CheckBox3.Location = new System.Drawing.Point(-51, -18);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(202, 24);
            this.CheckBox3.TabIndex = 31;
            this.CheckBox3.Text = "Evitar Repeticiones";
            this.CheckBox3.UseVisualStyleBackColor = true;
            // 
            // datalistadoEstructuraCONParametros
            // 
            this.datalistadoEstructuraCONParametros.AllowUserToAddRows = false;
            this.datalistadoEstructuraCONParametros.AllowUserToDeleteRows = false;
            this.datalistadoEstructuraCONParametros.AllowUserToResizeRows = false;
            this.datalistadoEstructuraCONParametros.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.datalistadoEstructuraCONParametros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistadoEstructuraCONParametros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistadoEstructuraCONParametros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistadoEstructuraCONParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadoEstructuraCONParametros.ColumnHeadersVisible = false;
            this.datalistadoEstructuraCONParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parametros2,
            this.Tipo2,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9,
            this.Enumeracion2,
            this.DataGridViewTextBoxColumn11,
            this.DataGridViewTextBoxColumn12,
            this.DataGridViewTextBoxColumn13,
            this.DataGridViewTextBoxColumn14,
            this.DataGridViewTextBoxColumn15,
            this.DataGridViewTextBoxColumn16,
            this.DataGridViewTextBoxColumn17,
            this.DataGridViewTextBoxColumn18,
            this.DataGridViewTextBoxColumn19,
            this.DataGridViewTextBoxColumn20,
            this.DataGridViewTextBoxColumn21,
            this.DataGridViewTextBoxColumn22,
            this.Marcar});
            this.datalistadoEstructuraCONParametros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datalistadoEstructuraCONParametros.GridColor = System.Drawing.Color.DimGray;
            this.datalistadoEstructuraCONParametros.Location = new System.Drawing.Point(0, -105);
            this.datalistadoEstructuraCONParametros.Name = "datalistadoEstructuraCONParametros";
            this.datalistadoEstructuraCONParametros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistadoEstructuraCONParametros.RowHeadersVisible = false;
            this.datalistadoEstructuraCONParametros.RowHeadersWidth = 51;
            this.datalistadoEstructuraCONParametros.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.datalistadoEstructuraCONParametros.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.datalistadoEstructuraCONParametros.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.datalistadoEstructuraCONParametros.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.datalistadoEstructuraCONParametros.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datalistadoEstructuraCONParametros.RowTemplate.Height = 40;
            this.datalistadoEstructuraCONParametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoEstructuraCONParametros.Size = new System.Drawing.Size(28, 155);
            this.datalistadoEstructuraCONParametros.TabIndex = 15;
            // 
            // Parametros2
            // 
            this.Parametros2.HeaderText = "Parametros";
            this.Parametros2.MinimumWidth = 6;
            this.Parametros2.Name = "Parametros2";
            this.Parametros2.Width = 125;
            // 
            // Tipo2
            // 
            this.Tipo2.HeaderText = "Tipo";
            this.Tipo2.MinimumWidth = 6;
            this.Tipo2.Name = "Tipo2";
            this.Tipo2.Visible = false;
            this.Tipo2.Width = 125;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText = "Longitud";
            this.DataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.Visible = false;
            this.DataGridViewTextBoxColumn3.Width = 125;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText = "Column1";
            this.DataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.Visible = false;
            this.DataGridViewTextBoxColumn4.Width = 125;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText = "Column2";
            this.DataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.Visible = false;
            this.DataGridViewTextBoxColumn5.Width = 125;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.HeaderText = "Column3";
            this.DataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.Visible = false;
            this.DataGridViewTextBoxColumn6.Width = 125;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.HeaderText = "Column4";
            this.DataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.Visible = false;
            this.DataGridViewTextBoxColumn7.Width = 125;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.HeaderText = "Column5";
            this.DataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.Visible = false;
            this.DataGridViewTextBoxColumn8.Width = 125;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.HeaderText = "Column6";
            this.DataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.Visible = false;
            this.DataGridViewTextBoxColumn9.Width = 125;
            // 
            // Enumeracion2
            // 
            this.Enumeracion2.HeaderText = "Enumeracion";
            this.Enumeracion2.MinimumWidth = 6;
            this.Enumeracion2.Name = "Enumeracion2";
            this.Enumeracion2.Visible = false;
            this.Enumeracion2.Width = 125;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.HeaderText = "Column8";
            this.DataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.Visible = false;
            this.DataGridViewTextBoxColumn11.Width = 125;
            // 
            // DataGridViewTextBoxColumn12
            // 
            this.DataGridViewTextBoxColumn12.HeaderText = "Column9";
            this.DataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.Visible = false;
            this.DataGridViewTextBoxColumn12.Width = 125;
            // 
            // DataGridViewTextBoxColumn13
            // 
            this.DataGridViewTextBoxColumn13.HeaderText = "Column10";
            this.DataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.Visible = false;
            this.DataGridViewTextBoxColumn13.Width = 125;
            // 
            // DataGridViewTextBoxColumn14
            // 
            this.DataGridViewTextBoxColumn14.HeaderText = "Column11";
            this.DataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.Visible = false;
            this.DataGridViewTextBoxColumn14.Width = 125;
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.HeaderText = "Column12";
            this.DataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.Visible = false;
            this.DataGridViewTextBoxColumn15.Width = 125;
            // 
            // DataGridViewTextBoxColumn16
            // 
            this.DataGridViewTextBoxColumn16.HeaderText = "Column13";
            this.DataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            this.DataGridViewTextBoxColumn16.Visible = false;
            this.DataGridViewTextBoxColumn16.Width = 125;
            // 
            // DataGridViewTextBoxColumn17
            // 
            this.DataGridViewTextBoxColumn17.HeaderText = "Column14";
            this.DataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            this.DataGridViewTextBoxColumn17.Visible = false;
            this.DataGridViewTextBoxColumn17.Width = 125;
            // 
            // DataGridViewTextBoxColumn18
            // 
            this.DataGridViewTextBoxColumn18.HeaderText = "Column15";
            this.DataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            this.DataGridViewTextBoxColumn18.Visible = false;
            this.DataGridViewTextBoxColumn18.Width = 125;
            // 
            // DataGridViewTextBoxColumn19
            // 
            this.DataGridViewTextBoxColumn19.HeaderText = "Column16";
            this.DataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
            this.DataGridViewTextBoxColumn19.Visible = false;
            this.DataGridViewTextBoxColumn19.Width = 125;
            // 
            // DataGridViewTextBoxColumn20
            // 
            this.DataGridViewTextBoxColumn20.HeaderText = "Column17";
            this.DataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
            this.DataGridViewTextBoxColumn20.Visible = false;
            this.DataGridViewTextBoxColumn20.Width = 125;
            // 
            // DataGridViewTextBoxColumn21
            // 
            this.DataGridViewTextBoxColumn21.HeaderText = "Column18";
            this.DataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
            this.DataGridViewTextBoxColumn21.Visible = false;
            this.DataGridViewTextBoxColumn21.Width = 125;
            // 
            // DataGridViewTextBoxColumn22
            // 
            this.DataGridViewTextBoxColumn22.HeaderText = "Column19";
            this.DataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
            this.DataGridViewTextBoxColumn22.Visible = false;
            this.DataGridViewTextBoxColumn22.Width = 125;
            // 
            // Marcar
            // 
            this.Marcar.HeaderText = "Marcar";
            this.Marcar.MinimumWidth = 6;
            this.Marcar.Name = "Marcar";
            this.Marcar.Width = 125;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(4, 7);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(207, 20);
            this.Label12.TabIndex = 9;
            this.Label12.Text = "Parametros a controlar";
            // 
            // ConParametrosCsharp
            // 
            this.ConParametrosCsharp.AutoSize = true;
            this.ConParametrosCsharp.Font = new System.Drawing.Font("Consolas", 10F);
            this.ConParametrosCsharp.ForeColor = System.Drawing.Color.White;
            this.ConParametrosCsharp.Location = new System.Drawing.Point(-15, 4);
            this.ConParametrosCsharp.Name = "ConParametrosCsharp";
            this.ConParametrosCsharp.Size = new System.Drawing.Size(157, 24);
            this.ConParametrosCsharp.TabIndex = 30;
            this.ConParametrosCsharp.Text = "Con parametros";
            this.ConParametrosCsharp.UseVisualStyleBackColor = true;
            // 
            // Button23
            // 
            this.Button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button23.FlatAppearance.BorderSize = 0;
            this.Button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button23.Location = new System.Drawing.Point(259, 43);
            this.Button23.Name = "Button23";
            this.Button23.Size = new System.Drawing.Size(94, 44);
            this.Button23.TabIndex = 39;
            this.Button23.Text = "Cortar";
            this.Button23.UseVisualStyleBackColor = false;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label8.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(0, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(360, 37);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Mostrar";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(5, 50);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(207, 28);
            this.Label11.TabIndex = 38;
            this.Label11.Text = "En DatagridView";
            // 
            // PanelEditar
            // 
            this.PanelEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelEditar.Controls.Add(this.CheckBox2);
            this.PanelEditar.Controls.Add(this.Button25);
            this.PanelEditar.Controls.Add(this.Label13);
            this.PanelEditar.Controls.Add(this.txtEditarCsharp);
            this.PanelEditar.Location = new System.Drawing.Point(9, 343);
            this.PanelEditar.Name = "PanelEditar";
            this.PanelEditar.Size = new System.Drawing.Size(356, 188);
            this.PanelEditar.TabIndex = 46;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Font = new System.Drawing.Font("Consolas", 10F);
            this.CheckBox2.ForeColor = System.Drawing.Color.White;
            this.CheckBox2.Location = new System.Drawing.Point(114, 28);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(157, 24);
            this.CheckBox2.TabIndex = 30;
            this.CheckBox2.Text = "Con parametros";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.Visible = false;
            // 
            // Button25
            // 
            this.Button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button25.FlatAppearance.BorderSize = 0;
            this.Button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button25.Location = new System.Drawing.Point(257, 16);
            this.Button25.Name = "Button25";
            this.Button25.Size = new System.Drawing.Size(94, 44);
            this.Button25.TabIndex = 29;
            this.Button25.Text = "Cortar";
            this.Button25.UseVisualStyleBackColor = false;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(3, 23);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(131, 40);
            this.Label13.TabIndex = 9;
            this.Label13.Text = "Editar";
            // 
            // txtEditarCsharp
            // 
            this.txtEditarCsharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEditarCsharp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditarCsharp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEditarCsharp.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtEditarCsharp.ForeColor = System.Drawing.Color.White;
            this.txtEditarCsharp.Location = new System.Drawing.Point(0, 74);
            this.txtEditarCsharp.Name = "txtEditarCsharp";
            this.txtEditarCsharp.ReadOnly = true;
            this.txtEditarCsharp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtEditarCsharp.Size = new System.Drawing.Size(356, 114);
            this.txtEditarCsharp.TabIndex = 11;
            this.txtEditarCsharp.Text = "";
            // 
            // PanelInsertar
            // 
            this.PanelInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelInsertar.Controls.Add(this.Button24);
            this.PanelInsertar.Controls.Add(this.Label14);
            this.PanelInsertar.Controls.Add(this.txtInsertarCsharp);
            this.PanelInsertar.Location = new System.Drawing.Point(381, 8);
            this.PanelInsertar.Name = "PanelInsertar";
            this.PanelInsertar.Size = new System.Drawing.Size(356, 328);
            this.PanelInsertar.TabIndex = 44;
            // 
            // Button24
            // 
            this.Button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button24.FlatAppearance.BorderSize = 0;
            this.Button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button24.Location = new System.Drawing.Point(242, 41);
            this.Button24.Name = "Button24";
            this.Button24.Size = new System.Drawing.Size(94, 44);
            this.Button24.TabIndex = 29;
            this.Button24.Text = "Copiar";
            this.Button24.UseVisualStyleBackColor = false;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(13, 42);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(169, 40);
            this.Label14.TabIndex = 9;
            this.Label14.Text = "Insertar";
            // 
            // txtInsertarCsharp
            // 
            this.txtInsertarCsharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtInsertarCsharp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsertarCsharp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInsertarCsharp.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtInsertarCsharp.ForeColor = System.Drawing.Color.White;
            this.txtInsertarCsharp.Location = new System.Drawing.Point(0, 96);
            this.txtInsertarCsharp.Name = "txtInsertarCsharp";
            this.txtInsertarCsharp.ReadOnly = true;
            this.txtInsertarCsharp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInsertarCsharp.Size = new System.Drawing.Size(356, 232);
            this.txtInsertarCsharp.TabIndex = 11;
            this.txtInsertarCsharp.Text = "";
            // 
            // PanelSQLServer
            // 
            this.PanelSQLServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSQLServer.Controls.Add(this.Panel18);
            this.PanelSQLServer.Controls.Add(this.Panel17);
            this.PanelSQLServer.Controls.Add(this.Panel16);
            this.PanelSQLServer.Controls.Add(this.Button16);
            this.PanelSQLServer.Controls.Add(this.Button15);
            this.PanelSQLServer.Controls.Add(this.Panel3);
            this.PanelSQLServer.Controls.Add(this.Panel9);
            this.PanelSQLServer.Controls.Add(this.Panel4);
            this.PanelSQLServer.Controls.Add(this.Panel6);
            this.PanelSQLServer.Location = new System.Drawing.Point(482, 97);
            this.PanelSQLServer.Name = "PanelSQLServer";
            this.PanelSQLServer.Size = new System.Drawing.Size(306, 575);
            this.PanelSQLServer.TabIndex = 30;
            this.PanelSQLServer.Visible = false;
            // 
            // Panel18
            // 
            this.Panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Panel18.Controls.Add(this.StatusStrip5);
            this.Panel18.Controls.Add(this.Label21);
            this.Panel18.Location = new System.Drawing.Point(746, 126);
            this.Panel18.Name = "Panel18";
            this.Panel18.Size = new System.Drawing.Size(451, 49);
            this.Panel18.TabIndex = 30;
            this.Panel18.Visible = false;
            // 
            // StatusStrip5
            // 
            this.StatusStrip5.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton8,
            this.ToolStripButton9,
            this.ToolStripButton10});
            this.StatusStrip5.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip5.Location = new System.Drawing.Point(168, 11);
            this.StatusStrip5.Name = "StatusStrip5";
            this.StatusStrip5.Size = new System.Drawing.Size(294, 34);
            this.StatusStrip5.TabIndex = 38;
            this.StatusStrip5.Text = "StatusStrip3";
            // 
            // ToolStripButton8
            // 
            this.ToolStripButton8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton8.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton8.Image = global::CRUD.Properties.Resources.jugar;
            this.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton8.Name = "ToolStripButton8";
            this.ToolStripButton8.Size = new System.Drawing.Size(113, 32);
            this.ToolStripButton8.Text = "Ejecutar";
            // 
            // ToolStripButton9
            // 
            this.ToolStripButton9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton9.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton9.Image = global::CRUD.Properties.Resources.papel;
            this.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton9.Name = "ToolStripButton9";
            this.ToolStripButton9.Size = new System.Drawing.Size(97, 32);
            this.ToolStripButton9.Text = "Copiar";
            // 
            // ToolStripButton10
            // 
            this.ToolStripButton10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton10.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton10.Image")));
            this.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton10.Name = "ToolStripButton10";
            this.ToolStripButton10.Size = new System.Drawing.Size(67, 32);
            this.ToolStripButton10.Text = "Ver";
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.Transparent;
            this.Label21.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label21.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Label21.ForeColor = System.Drawing.Color.White;
            this.Label21.Location = new System.Drawing.Point(0, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(135, 49);
            this.Label21.TabIndex = 37;
            this.Label21.Text = "Eliminar";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel17
            // 
            this.Panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Panel17.Controls.Add(this.StatusStrip4);
            this.Panel17.Controls.Add(this.Label9);
            this.Panel17.Location = new System.Drawing.Point(746, 71);
            this.Panel17.Name = "Panel17";
            this.Panel17.Size = new System.Drawing.Size(451, 49);
            this.Panel17.TabIndex = 30;
            this.Panel17.Visible = false;
            // 
            // StatusStrip4
            // 
            this.StatusStrip4.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton5,
            this.ToolStripButton6,
            this.ToolStripButton7});
            this.StatusStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip4.Location = new System.Drawing.Point(168, 11);
            this.StatusStrip4.Name = "StatusStrip4";
            this.StatusStrip4.Size = new System.Drawing.Size(294, 34);
            this.StatusStrip4.TabIndex = 38;
            this.StatusStrip4.Text = "StatusStrip3";
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton5.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton5.Image = global::CRUD.Properties.Resources.jugar;
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(113, 32);
            this.ToolStripButton5.Text = "Ejecutar";
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton6.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton6.Image = global::CRUD.Properties.Resources.papel;
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(97, 32);
            this.ToolStripButton6.Text = "Copiar";
            // 
            // ToolStripButton7
            // 
            this.ToolStripButton7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton7.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton7.Image")));
            this.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton7.Name = "ToolStripButton7";
            this.ToolStripButton7.Size = new System.Drawing.Size(67, 32);
            this.ToolStripButton7.Text = "Ver";
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(0, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(135, 49);
            this.Label9.TabIndex = 37;
            this.Label9.Text = "Mostrar";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel16
            // 
            this.Panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Panel16.Controls.Add(this.StatusStrip3);
            this.Panel16.Controls.Add(this.Label7);
            this.Panel16.Location = new System.Drawing.Point(746, 16);
            this.Panel16.Name = "Panel16";
            this.Panel16.Size = new System.Drawing.Size(451, 49);
            this.Panel16.TabIndex = 30;
            this.Panel16.Visible = false;
            // 
            // StatusStrip3
            // 
            this.StatusStrip3.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton3,
            this.ToolStripButton4,
            this.ToolStripButton11});
            this.StatusStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip3.Location = new System.Drawing.Point(168, 11);
            this.StatusStrip3.Name = "StatusStrip3";
            this.StatusStrip3.Size = new System.Drawing.Size(294, 34);
            this.StatusStrip3.TabIndex = 38;
            this.StatusStrip3.Text = "StatusStrip3";
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton3.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton3.Image = global::CRUD.Properties.Resources.jugar;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(113, 32);
            this.ToolStripButton3.Text = "Ejecutar";
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton4.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton4.Image = global::CRUD.Properties.Resources.papel;
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(97, 32);
            this.ToolStripButton4.Text = "Copiar";
            // 
            // ToolStripButton11
            // 
            this.ToolStripButton11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton11.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton11.Image")));
            this.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton11.Name = "ToolStripButton11";
            this.ToolStripButton11.Size = new System.Drawing.Size(67, 32);
            this.ToolStripButton11.Text = "Ver";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(135, 49);
            this.Label7.TabIndex = 37;
            this.Label7.Text = "Editar";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button16
            // 
            this.Button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button16.FlatAppearance.BorderSize = 0;
            this.Button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button16.Location = new System.Drawing.Point(197, 10);
            this.Button16.Name = "Button16";
            this.Button16.Size = new System.Drawing.Size(202, 37);
            this.Button16.TabIndex = 29;
            this.Button16.Text = "Ejecutar CRUD Completo";
            this.Button16.UseVisualStyleBackColor = false;
            // 
            // Button15
            // 
            this.Button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button15.FlatAppearance.BorderSize = 0;
            this.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button15.Location = new System.Drawing.Point(6, 10);
            this.Button15.Name = "Button15";
            this.Button15.Size = new System.Drawing.Size(185, 37);
            this.Button15.TabIndex = 29;
            this.Button15.Text = "Copiar CRUD completo";
            this.Button15.UseVisualStyleBackColor = false;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Panel3.Controls.Add(this.PanelVerInsertarSQLserver);
            this.Panel3.Controls.Add(this.StatusStrip2);
            this.Panel3.Controls.Add(this.StatusStrip1);
            this.Panel3.Controls.Add(this.PanelRepeticiones);
            this.Panel3.Controls.Add(this.EvitarRepeticionesSQLServer);
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Panel3.Location = new System.Drawing.Point(6, 53);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(356, 293);
            this.Panel3.TabIndex = 24;
            // 
            // PanelVerInsertarSQLserver
            // 
            this.PanelVerInsertarSQLserver.Controls.Add(this.txtInsertarSQLServer);
            this.PanelVerInsertarSQLserver.Location = new System.Drawing.Point(295, 62);
            this.PanelVerInsertarSQLserver.Name = "PanelVerInsertarSQLserver";
            this.PanelVerInsertarSQLserver.Size = new System.Drawing.Size(37, 33);
            this.PanelVerInsertarSQLserver.TabIndex = 37;
            this.PanelVerInsertarSQLserver.Visible = false;
            // 
            // StatusStrip2
            // 
            this.StatusStrip2.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSQLver,
            this.TSQLvolver});
            this.StatusStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip2.Location = new System.Drawing.Point(0, 264);
            this.StatusStrip2.Name = "StatusStrip2";
            this.StatusStrip2.Size = new System.Drawing.Size(356, 29);
            this.StatusStrip2.TabIndex = 36;
            this.StatusStrip2.Text = "StatusStrip1";
            // 
            // TSQLver
            // 
            this.TSQLver.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TSQLver.ForeColor = System.Drawing.Color.White;
            this.TSQLver.Image = ((System.Drawing.Image)(resources.GetObject("TSQLver.Image")));
            this.TSQLver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSQLver.Name = "TSQLver";
            this.TSQLver.Size = new System.Drawing.Size(67, 27);
            this.TSQLver.Text = "Ver";
            // 
            // TSQLvolver
            // 
            this.TSQLvolver.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TSQLvolver.ForeColor = System.Drawing.Color.White;
            this.TSQLvolver.Image = global::CRUD.Properties.Resources.regreso;
            this.TSQLvolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSQLvolver.Name = "TSQLvolver";
            this.TSQLvolver.Size = new System.Drawing.Size(100, 27);
            this.TSQLvolver.Text = "Volver";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.ToolStripButton2});
            this.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip1.Location = new System.Drawing.Point(168, 22);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(227, 34);
            this.StatusStrip1.TabIndex = 36;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton1.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton1.Image = global::CRUD.Properties.Resources.jugar;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(113, 32);
            this.ToolStripButton1.Text = "Ejecutar";
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ToolStripButton2.ForeColor = System.Drawing.Color.White;
            this.ToolStripButton2.Image = global::CRUD.Properties.Resources.papel;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(97, 32);
            this.ToolStripButton2.Text = "Copiar";
            // 
            // PanelRepeticiones
            // 
            this.PanelRepeticiones.Controls.Add(this.Label17);
            this.PanelRepeticiones.Controls.Add(this.ComboBox1);
            this.PanelRepeticiones.Controls.Add(this.Label10);
            this.PanelRepeticiones.Controls.Add(this.lblRepeticionesSQLServer1);
            this.PanelRepeticiones.Controls.Add(this.txtErrorSQLServer);
            this.PanelRepeticiones.Controls.Add(this.lblRepeticionesSQLServer2);
            this.PanelRepeticiones.Location = new System.Drawing.Point(6, 87);
            this.PanelRepeticiones.Name = "PanelRepeticiones";
            this.PanelRepeticiones.Size = new System.Drawing.Size(350, 174);
            this.PanelRepeticiones.TabIndex = 0;
            this.PanelRepeticiones.Visible = false;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label17.ForeColor = System.Drawing.Color.Silver;
            this.Label17.Location = new System.Drawing.Point(3, 45);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(356, 23);
            this.Label17.TabIndex = 37;
            this.Label17.Text = "Digita # para Obtener los Campos de Tabla";
            // 
            // ComboBox1
            // 
            this.ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBox1.DropDownHeight = 200;
            this.ComboBox1.DropDownWidth = 300;
            this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox1.ForeColor = System.Drawing.Color.White;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.IntegralHeight = false;
            this.ComboBox1.Location = new System.Drawing.Point(3, 69);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(204, 31);
            this.ComboBox1.TabIndex = 36;
            this.ComboBox1.Visible = false;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Label10.ForeColor = System.Drawing.Color.Silver;
            this.Label10.Location = new System.Drawing.Point(0, 110);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(143, 23);
            this.Label10.TabIndex = 35;
            this.Label10.Text = "Mensaje de Error:";
            // 
            // lblRepeticionesSQLServer1
            // 
            this.lblRepeticionesSQLServer1.BackColor = System.Drawing.Color.Transparent;
            this.lblRepeticionesSQLServer1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRepeticionesSQLServer1.ForeColor = System.Drawing.Color.Silver;
            this.lblRepeticionesSQLServer1.Location = new System.Drawing.Point(-3, -3);
            this.lblRepeticionesSQLServer1.Name = "lblRepeticionesSQLServer1";
            this.lblRepeticionesSQLServer1.Size = new System.Drawing.Size(344, 30);
            this.lblRepeticionesSQLServer1.TabIndex = 32;
            this.lblRepeticionesSQLServer1.Text = "if EXISTS (SELECT * FROM\r\nif EXISTS (SELECT * FROM";
            // 
            // txtErrorSQLServer
            // 
            this.txtErrorSQLServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtErrorSQLServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrorSQLServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtErrorSQLServer.ForeColor = System.Drawing.Color.White;
            this.txtErrorSQLServer.Location = new System.Drawing.Point(3, 133);
            this.txtErrorSQLServer.Name = "txtErrorSQLServer";
            this.txtErrorSQLServer.Size = new System.Drawing.Size(338, 38);
            this.txtErrorSQLServer.TabIndex = 38;
            this.txtErrorSQLServer.Text = "";
            // 
            // lblRepeticionesSQLServer2
            // 
            this.lblRepeticionesSQLServer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRepeticionesSQLServer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRepeticionesSQLServer2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRepeticionesSQLServer2.ForeColor = System.Drawing.Color.White;
            this.lblRepeticionesSQLServer2.Location = new System.Drawing.Point(3, 68);
            this.lblRepeticionesSQLServer2.Name = "lblRepeticionesSQLServer2";
            this.lblRepeticionesSQLServer2.Size = new System.Drawing.Size(338, 38);
            this.lblRepeticionesSQLServer2.TabIndex = 38;
            this.lblRepeticionesSQLServer2.Text = "";
            // 
            // EvitarRepeticionesSQLServer
            // 
            this.EvitarRepeticionesSQLServer.AutoSize = true;
            this.EvitarRepeticionesSQLServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EvitarRepeticionesSQLServer.ForeColor = System.Drawing.Color.White;
            this.EvitarRepeticionesSQLServer.Location = new System.Drawing.Point(6, 55);
            this.EvitarRepeticionesSQLServer.Name = "EvitarRepeticionesSQLServer";
            this.EvitarRepeticionesSQLServer.Size = new System.Drawing.Size(175, 27);
            this.EvitarRepeticionesSQLServer.TabIndex = 33;
            this.EvitarRepeticionesSQLServer.Text = "Evitar Repeticiones";
            this.EvitarRepeticionesSQLServer.UseVisualStyleBackColor = true;
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Panel9.Controls.Add(this.Button11);
            this.Panel9.Controls.Add(this.Button12);
            this.Panel9.Controls.Add(this.txtEliminar);
            this.Panel9.Controls.Add(this.Label6);
            this.Panel9.Location = new System.Drawing.Point(371, 352);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(357, 184);
            this.Panel9.TabIndex = 28;
            // 
            // Button11
            // 
            this.Button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button11.FlatAppearance.BorderSize = 0;
            this.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button11.Location = new System.Drawing.Point(121, 10);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(94, 44);
            this.Button11.TabIndex = 27;
            this.Button11.Text = "Copiar";
            this.Button11.UseVisualStyleBackColor = false;
            // 
            // Button12
            // 
            this.Button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button12.FlatAppearance.BorderSize = 0;
            this.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button12.Location = new System.Drawing.Point(221, 10);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(106, 44);
            this.Button12.TabIndex = 26;
            this.Button12.Text = "Ejecutar";
            this.Button12.UseVisualStyleBackColor = false;
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEliminar.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtEliminar.ForeColor = System.Drawing.Color.White;
            this.txtEliminar.Location = new System.Drawing.Point(3, 63);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtEliminar.Size = new System.Drawing.Size(318, 110);
            this.txtEliminar.TabIndex = 17;
            this.txtEliminar.Text = "Null";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(3, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(143, 34);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "Eliminar";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Panel4.Controls.Add(this.Button9);
            this.Panel4.Controls.Add(this.Button10);
            this.Panel4.Controls.Add(this.txtEditar);
            this.Panel4.Controls.Add(this.Label1);
            this.Panel4.Location = new System.Drawing.Point(371, 53);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(357, 293);
            this.Panel4.TabIndex = 25;
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button9.Location = new System.Drawing.Point(117, 39);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(94, 44);
            this.Button9.TabIndex = 27;
            this.Button9.Text = "Copiar";
            this.Button9.UseVisualStyleBackColor = false;
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button10.FlatAppearance.BorderSize = 0;
            this.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button10.Location = new System.Drawing.Point(217, 39);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(106, 44);
            this.Button10.TabIndex = 26;
            this.Button10.Text = "Ejecutar";
            this.Button10.UseVisualStyleBackColor = false;
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Panel6.Controls.Add(this.Button13);
            this.Panel6.Controls.Add(this.Button14);
            this.Panel6.Controls.Add(this.txtMostrar);
            this.Panel6.Controls.Add(this.Label2);
            this.Panel6.Location = new System.Drawing.Point(6, 352);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(356, 184);
            this.Panel6.TabIndex = 26;
            // 
            // Button13
            // 
            this.Button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button13.FlatAppearance.BorderSize = 0;
            this.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button13.Location = new System.Drawing.Point(144, 13);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(94, 44);
            this.Button13.TabIndex = 27;
            this.Button13.Text = "Copiar";
            this.Button13.UseVisualStyleBackColor = false;
            // 
            // Button14
            // 
            this.Button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Button14.FlatAppearance.BorderSize = 0;
            this.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button14.Location = new System.Drawing.Point(244, 13);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(106, 44);
            this.Button14.TabIndex = 26;
            this.Button14.Text = "Ejecutar";
            this.Button14.UseVisualStyleBackColor = false;
            // 
            // PanelTABLET
            // 
            this.PanelTABLET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelTABLET.Controls.Add(this.Panel25);
            this.PanelTABLET.Controls.Add(this.Panel7);
            this.PanelTABLET.Controls.Add(this.Panel14);
            this.PanelTABLET.Controls.Add(this.Panel13);
            this.PanelTABLET.Controls.Add(this.Panel12);
            this.PanelTABLET.Controls.Add(this.Panel10);
            this.PanelTABLET.Controls.Add(this.Panel8);
            this.PanelTABLET.Controls.Add(this.Panel15);
            this.PanelTABLET.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTABLET.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTABLET.Location = new System.Drawing.Point(0, 0);
            this.PanelTABLET.Name = "PanelTABLET";
            this.PanelTABLET.Size = new System.Drawing.Size(968, 29);
            this.PanelTABLET.TabIndex = 27;
            // 
            // Panel25
            // 
            this.Panel25.Controls.Add(this.Button18);
            this.Panel25.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel25.Font = new System.Drawing.Font("Consolas", 16F);
            this.Panel25.Location = new System.Drawing.Point(667, 0);
            this.Panel25.Name = "Panel25";
            this.Panel25.Size = new System.Drawing.Size(98, 27);
            this.Panel25.TabIndex = 8;
            // 
            // Button18
            // 
            this.Button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button18.Enabled = false;
            this.Button18.FlatAppearance.BorderSize = 0;
            this.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button18.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Button18.ForeColor = System.Drawing.Color.DarkGray;
            this.Button18.Location = new System.Drawing.Point(0, 0);
            this.Button18.Name = "Button18";
            this.Button18.Size = new System.Drawing.Size(98, 27);
            this.Button18.TabIndex = 0;
            this.Button18.Text = "MVVC C#";
            this.Button18.UseVisualStyleBackColor = false;
            // 
            // Panel7
            // 
            this.Panel7.Controls.Add(this.Button6);
            this.Panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel7.Font = new System.Drawing.Font("Consolas", 16F);
            this.Panel7.Location = new System.Drawing.Point(567, 0);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(100, 27);
            this.Panel7.TabIndex = 6;
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Button6.ForeColor = System.Drawing.Color.DarkGray;
            this.Button6.Image = ((System.Drawing.Image)(resources.GetObject("Button6.Image")));
            this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button6.Location = new System.Drawing.Point(0, 0);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(100, 27);
            this.Button6.TabIndex = 0;
            this.Button6.Text = "MySql\r\n(pronto)";
            this.Button6.UseVisualStyleBackColor = false;
            // 
            // Panel14
            // 
            this.Panel14.Controls.Add(this.Button5);
            this.Panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel14.Font = new System.Drawing.Font("Consolas", 16F);
            this.Panel14.Location = new System.Drawing.Point(464, 0);
            this.Panel14.Name = "Panel14";
            this.Panel14.Size = new System.Drawing.Size(103, 27);
            this.Panel14.TabIndex = 5;
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Button5.ForeColor = System.Drawing.Color.DarkGray;
            this.Button5.Image = ((System.Drawing.Image)(resources.GetObject("Button5.Image")));
            this.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button5.Location = new System.Drawing.Point(0, 0);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(103, 27);
            this.Button5.TabIndex = 0;
            this.Button5.Text = "Java\r\n(pronto)";
            this.Button5.UseVisualStyleBackColor = false;
            // 
            // Panel13
            // 
            this.Panel13.Controls.Add(this.Button4);
            this.Panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel13.Font = new System.Drawing.Font("Consolas", 16F);
            this.Panel13.Location = new System.Drawing.Point(360, 0);
            this.Panel13.Name = "Panel13";
            this.Panel13.Size = new System.Drawing.Size(104, 27);
            this.Panel13.TabIndex = 4;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Button4.ForeColor = System.Drawing.Color.DarkGray;
            this.Button4.Image = ((System.Drawing.Image)(resources.GetObject("Button4.Image")));
            this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button4.Location = new System.Drawing.Point(0, 0);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(104, 27);
            this.Button4.TabIndex = 0;
            this.Button4.Text = "Python\r\n(pronto)";
            this.Button4.UseVisualStyleBackColor = false;
            // 
            // Panel12
            // 
            this.Panel12.Controls.Add(this.btnCsharp);
            this.Panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel12.Font = new System.Drawing.Font("Consolas", 16F);
            this.Panel12.Location = new System.Drawing.Point(276, 0);
            this.Panel12.Name = "Panel12";
            this.Panel12.Size = new System.Drawing.Size(84, 27);
            this.Panel12.TabIndex = 3;
            // 
            // btnCsharp
            // 
            this.btnCsharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCsharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCsharp.FlatAppearance.BorderSize = 0;
            this.btnCsharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsharp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCsharp.ForeColor = System.Drawing.Color.White;
            this.btnCsharp.Image = ((System.Drawing.Image)(resources.GetObject("btnCsharp.Image")));
            this.btnCsharp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCsharp.Location = new System.Drawing.Point(0, 0);
            this.btnCsharp.Name = "btnCsharp";
            this.btnCsharp.Size = new System.Drawing.Size(84, 27);
            this.btnCsharp.TabIndex = 0;
            this.btnCsharp.Text = "C#";
            this.btnCsharp.UseVisualStyleBackColor = false;
            // 
            // Panel10
            // 
            this.Panel10.Controls.Add(this.btnVb);
            this.Panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel10.Font = new System.Drawing.Font("Consolas", 16F);
            this.Panel10.Location = new System.Drawing.Point(130, 0);
            this.Panel10.Name = "Panel10";
            this.Panel10.Size = new System.Drawing.Size(146, 27);
            this.Panel10.TabIndex = 2;
            // 
            // btnVb
            // 
            this.btnVb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVb.FlatAppearance.BorderSize = 0;
            this.btnVb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVb.ForeColor = System.Drawing.Color.White;
            this.btnVb.Image = ((System.Drawing.Image)(resources.GetObject("btnVb.Image")));
            this.btnVb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVb.Location = new System.Drawing.Point(0, 0);
            this.btnVb.Name = "btnVb";
            this.btnVb.Size = new System.Drawing.Size(146, 27);
            this.btnVb.TabIndex = 0;
            this.btnVb.Text = "Visual Basic.Net";
            this.btnVb.UseVisualStyleBackColor = false;
            // 
            // Panel8
            // 
            this.Panel8.Controls.Add(this.btnSQLSERVER);
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel8.Font = new System.Drawing.Font("Consolas", 16F);
            this.Panel8.Location = new System.Drawing.Point(0, 0);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(130, 27);
            this.Panel8.TabIndex = 1;
            // 
            // btnSQLSERVER
            // 
            this.btnSQLSERVER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSQLSERVER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSQLSERVER.FlatAppearance.BorderSize = 0;
            this.btnSQLSERVER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSQLSERVER.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSQLSERVER.ForeColor = System.Drawing.Color.White;
            this.btnSQLSERVER.Image = ((System.Drawing.Image)(resources.GetObject("btnSQLSERVER.Image")));
            this.btnSQLSERVER.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSQLSERVER.Location = new System.Drawing.Point(0, 0);
            this.btnSQLSERVER.Name = "btnSQLSERVER";
            this.btnSQLSERVER.Size = new System.Drawing.Size(130, 27);
            this.btnSQLSERVER.TabIndex = 0;
            this.btnSQLSERVER.Text = "SQLServer";
            this.btnSQLSERVER.UseVisualStyleBackColor = false;
            // 
            // Panel15
            // 
            this.Panel15.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel15.Location = new System.Drawing.Point(0, 27);
            this.Panel15.Name = "Panel15";
            this.Panel15.Size = new System.Drawing.Size(968, 2);
            this.Panel15.TabIndex = 7;
            // 
            // PanelBienvenida
            // 
            this.PanelBienvenida.Controls.Add(this.Label15);
            this.PanelBienvenida.Location = new System.Drawing.Point(262, 298);
            this.PanelBienvenida.Name = "PanelBienvenida";
            this.PanelBienvenida.Size = new System.Drawing.Size(51, 162);
            this.PanelBienvenida.TabIndex = 32;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label15.Font = new System.Drawing.Font("Consolas", 50F);
            this.Label15.ForeColor = System.Drawing.Color.LightGray;
            this.Label15.Location = new System.Drawing.Point(0, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(51, 162);
            this.Label15.TabIndex = 0;
            this.Label15.Text = "Elija una TABLA para Empezar";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMvvcCsharp
            // 
            this.PanelMvvcCsharp.Controls.Add(this.txtModeloCsharp);
            this.PanelMvvcCsharp.Location = new System.Drawing.Point(239, 47);
            this.PanelMvvcCsharp.Name = "PanelMvvcCsharp";
            this.PanelMvvcCsharp.Size = new System.Drawing.Size(74, 55);
            this.PanelMvvcCsharp.TabIndex = 34;
            this.PanelMvvcCsharp.Visible = false;
            // 
            // txtModeloCsharp
            // 
            this.txtModeloCsharp.Location = new System.Drawing.Point(46, 27);
            this.txtModeloCsharp.Name = "txtModeloCsharp";
            this.txtModeloCsharp.Size = new System.Drawing.Size(341, 160);
            this.txtModeloCsharp.TabIndex = 0;
            this.txtModeloCsharp.Text = "";
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.datalistado_TABLAS);
            this.Panel5.Controls.Add(this.Panel1);
            this.Panel5.Controls.Add(this.Panel19);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel5.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel5.Location = new System.Drawing.Point(27, 114);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(346, 619);
            this.Panel5.TabIndex = 4;
            // 
            // Panel19
            // 
            this.Panel19.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel19.Location = new System.Drawing.Point(0, 590);
            this.Panel19.Name = "Panel19";
            this.Panel19.Size = new System.Drawing.Size(344, 27);
            this.Panel19.TabIndex = 15;
            // 
            // Panel28
            // 
            this.Panel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Panel28.Controls.Add(this.Panel30);
            this.Panel28.Controls.Add(this.Panel29);
            this.Panel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel28.Location = new System.Drawing.Point(0, 0);
            this.Panel28.Name = "Panel28";
            this.Panel28.Size = new System.Drawing.Size(1348, 114);
            this.Panel28.TabIndex = 5;
            // 
            // Panel30
            // 
            this.Panel30.Controls.Add(this.VerCodigo);
            this.Panel30.Controls.Add(this.Panel34);
            this.Panel30.Controls.Add(this.Button2);
            this.Panel30.Controls.Add(this.PictureBox3);
            this.Panel30.Controls.Add(this.Button7);
            this.Panel30.Controls.Add(this.Button17);
            this.Panel30.Controls.Add(this.Panel32);
            this.Panel30.Controls.Add(this.Panel26);
            this.Panel30.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel30.Location = new System.Drawing.Point(0, 57);
            this.Panel30.Name = "Panel30";
            this.Panel30.Size = new System.Drawing.Size(1348, 52);
            this.Panel30.TabIndex = 13;
            // 
            // VerCodigo
            // 
            this.VerCodigo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.VerCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VerCodigo.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerCodigo.FlatAppearance.BorderSize = 0;
            this.VerCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VerCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VerCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.VerCodigo.ForeColor = System.Drawing.Color.White;
            this.VerCodigo.Image = ((System.Drawing.Image)(resources.GetObject("VerCodigo.Image")));
            this.VerCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerCodigo.Location = new System.Drawing.Point(558, 24);
            this.VerCodigo.Name = "VerCodigo";
            this.VerCodigo.Size = new System.Drawing.Size(276, 28);
            this.VerCodigo.TabIndex = 37;
            this.VerCodigo.Text = "VER CODIGO FUENTE Y COMO SE HIZO";
            this.VerCodigo.UseVisualStyleBackColor = false;
            this.VerCodigo.Click += new System.EventHandler(this.VerCodigo_Click);
            // 
            // Panel34
            // 
            this.Panel34.Controls.Add(this.Label22);
            this.Panel34.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel34.Location = new System.Drawing.Point(535, 24);
            this.Panel34.Name = "Panel34";
            this.Panel34.Size = new System.Drawing.Size(23, 28);
            this.Panel34.TabIndex = 40;
            this.Panel34.Visible = false;
            // 
            // Label22
            // 
            this.Label22.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Label22.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.Color.White;
            this.Label22.Location = new System.Drawing.Point(1, 5);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(19, 19);
            this.Label22.TabIndex = 0;
            this.Label22.Text = "2";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(417, 24);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(118, 28);
            this.Button2.TabIndex = 39;
            this.Button2.Text = "Formulas aplicadas";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Visible = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(380, 24);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(37, 28);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 38;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Visible = false;
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Image = ((System.Drawing.Image)(resources.GetObject("Button7.Image")));
            this.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button7.Location = new System.Drawing.Point(181, 24);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(199, 28);
            this.Button7.TabIndex = 34;
            this.Button7.Text = "Reportar errores y mejoras";
            this.Button7.UseVisualStyleBackColor = true;
            // 
            // Button17
            // 
            this.Button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button17.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button17.FlatAppearance.BorderSize = 0;
            this.Button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button17.ForeColor = System.Drawing.Color.White;
            this.Button17.Image = ((System.Drawing.Image)(resources.GetObject("Button17.Image")));
            this.Button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button17.Location = new System.Drawing.Point(27, 24);
            this.Button17.Name = "Button17";
            this.Button17.Size = new System.Drawing.Size(154, 28);
            this.Button17.TabIndex = 30;
            this.Button17.Text = "Nueva Conexion";
            this.Button17.UseVisualStyleBackColor = true;
            // 
            // Panel32
            // 
            this.Panel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Panel32.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel32.Location = new System.Drawing.Point(0, 24);
            this.Panel32.Name = "Panel32";
            this.Panel32.Size = new System.Drawing.Size(27, 28);
            this.Panel32.TabIndex = 33;
            // 
            // Panel26
            // 
            this.Panel26.Controls.Add(this.StatusStrip6);
            this.Panel26.Controls.Add(this.Panel37);
            this.Panel26.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Panel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel26.Location = new System.Drawing.Point(0, 0);
            this.Panel26.Name = "Panel26";
            this.Panel26.Size = new System.Drawing.Size(1348, 24);
            this.Panel26.TabIndex = 36;
            // 
            // StatusStrip6
            // 
            this.StatusStrip6.BackColor = System.Drawing.Color.Transparent;
            this.StatusStrip6.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusStrip6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripDropDownButton2});
            this.StatusStrip6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip6.Location = new System.Drawing.Point(27, 0);
            this.StatusStrip6.Name = "StatusStrip6";
            this.StatusStrip6.Size = new System.Drawing.Size(82, 24);
            this.StatusStrip6.TabIndex = 39;
            this.StatusStrip6.Text = "StatusStrip6";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(186, 18);
            this.ToolStripStatusLabel1.Text = "Formulas (En construccion)";
            this.ToolStripStatusLabel1.Visible = false;
            // 
            // ToolStripDropDownButton2
            // 
            this.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaDeToolStripMenuItem});
            this.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.White;
            this.ToolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDropDownButton2.Image")));
            this.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2";
            this.ToolStripDropDownButton2.Size = new System.Drawing.Size(65, 22);
            this.ToolStripDropDownButton2.Text = "Ayuda";
            // 
            // AcercaDeToolStripMenuItem
            // 
            this.AcercaDeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AcercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AcercaDeToolStripMenuItem.Image")));
            this.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem";
            this.AcercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.AcercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // Panel37
            // 
            this.Panel37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Panel37.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel37.Location = new System.Drawing.Point(0, 0);
            this.Panel37.Name = "Panel37";
            this.Panel37.Size = new System.Drawing.Size(27, 24);
            this.Panel37.TabIndex = 34;
            // 
            // Panel29
            // 
            this.Panel29.Controls.Add(this.Label20);
            this.Panel29.Controls.Add(this.Panel21);
            this.Panel29.Controls.Add(this.PictureBox5);
            this.Panel29.Controls.Add(this.btnRestaurar);
            this.Panel29.Controls.Add(this.btnMaximizar);
            this.Panel29.Controls.Add(this.PictureBox2);
            this.Panel29.Controls.Add(this.Panel31);
            this.Panel29.Controls.Add(this.Panel35);
            this.Panel29.Controls.Add(this.Panel36);
            this.Panel29.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Panel29.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel29.Location = new System.Drawing.Point(0, 0);
            this.Panel29.Name = "Panel29";
            this.Panel29.Size = new System.Drawing.Size(1348, 57);
            this.Panel29.TabIndex = 12;
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label20.ForeColor = System.Drawing.Color.Gray;
            this.Label20.Location = new System.Drawing.Point(78, 21);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(228, 36);
            this.Label20.TabIndex = 18;
            this.Label20.Text = "(Administrador)";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel21
            // 
            this.Panel21.Controls.Add(this.PictureBox1);
            this.Panel21.Controls.Add(this.Panel24);
            this.Panel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel21.Location = new System.Drawing.Point(27, 21);
            this.Panel21.Name = "Panel21";
            this.Panel21.Size = new System.Drawing.Size(51, 36);
            this.Panel21.TabIndex = 35;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Image = global::CRUD.Properties.Resources.connec;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(51, 30);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 14;
            this.PictureBox1.TabStop = false;
            // 
            // Panel24
            // 
            this.Panel24.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel24.Location = new System.Drawing.Point(0, 30);
            this.Panel24.Name = "Panel24";
            this.Panel24.Size = new System.Drawing.Size(51, 6);
            this.Panel24.TabIndex = 15;
            // 
            // PictureBox5
            // 
            this.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBox5.Image = global::CRUD.Properties.Resources.Icono_Minimizar;
            this.PictureBox5.Location = new System.Drawing.Point(1218, 21);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(30, 36);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox5.TabIndex = 12;
            this.PictureBox5.TabStop = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestaurar.Image = global::CRUD.Properties.Resources.Icono_Restaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(1248, 21);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 36);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 12;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.Image = global::CRUD.Properties.Resources.Icono_Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(1278, 21);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 36);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 12;
            this.btnMaximizar.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBox2.Image = global::CRUD.Properties.Resources.ICON_CERRARF;
            this.PictureBox2.Location = new System.Drawing.Point(1308, 21);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(30, 36);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 12;
            this.PictureBox2.TabStop = false;
            // 
            // Panel31
            // 
            this.Panel31.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel31.Location = new System.Drawing.Point(1338, 21);
            this.Panel31.Name = "Panel31";
            this.Panel31.Size = new System.Drawing.Size(10, 36);
            this.Panel31.TabIndex = 19;
            // 
            // Panel35
            // 
            this.Panel35.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Panel35.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel35.Location = new System.Drawing.Point(27, 0);
            this.Panel35.Name = "Panel35";
            this.Panel35.Size = new System.Drawing.Size(1321, 21);
            this.Panel35.TabIndex = 36;
            // 
            // Panel36
            // 
            this.Panel36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Panel36.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel36.Location = new System.Drawing.Point(0, 0);
            this.Panel36.Name = "Panel36";
            this.Panel36.Size = new System.Drawing.Size(27, 57);
            this.Panel36.TabIndex = 34;
            // 
            // Panel33
            // 
            this.Panel33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Panel33.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel33.Location = new System.Drawing.Point(0, 114);
            this.Panel33.Name = "Panel33";
            this.Panel33.Size = new System.Drawing.Size(27, 619);
            this.Panel33.TabIndex = 32;
            // 
            // Panel38
            // 
            this.Panel38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Panel38.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel38.Location = new System.Drawing.Point(373, 114);
            this.Panel38.Name = "Panel38";
            this.Panel38.Size = new System.Drawing.Size(7, 619);
            this.Panel38.TabIndex = 33;
            // 
            // Generador_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 733);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel38);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel33);
            this.Controls.Add(this.Panel28);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Generador_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Versión Beta v.1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Generador_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_TABLAS)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel11.ResumeLayout(false);
            this.Panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoEstructura)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.PanelVb.ResumeLayout(false);
            this.Panel20.ResumeLayout(false);
            this.Panel20.PerformLayout();
            this.Panel22.ResumeLayout(false);
            this.Panel22.PerformLayout();
            this.Panel23.ResumeLayout(false);
            this.Panel23.PerformLayout();
            this.PanelCsharp.ResumeLayout(false);
            this.Panelmostrar.ResumeLayout(false);
            this.Panelmostrar.PerformLayout();
            this.Panel27.ResumeLayout(false);
            this.PanelParametros.ResumeLayout(false);
            this.PanelParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoEstructuraCONParametros)).EndInit();
            this.PanelEditar.ResumeLayout(false);
            this.PanelEditar.PerformLayout();
            this.PanelInsertar.ResumeLayout(false);
            this.PanelInsertar.PerformLayout();
            this.PanelSQLServer.ResumeLayout(false);
            this.Panel18.ResumeLayout(false);
            this.Panel18.PerformLayout();
            this.StatusStrip5.ResumeLayout(false);
            this.StatusStrip5.PerformLayout();
            this.Panel17.ResumeLayout(false);
            this.Panel17.PerformLayout();
            this.StatusStrip4.ResumeLayout(false);
            this.StatusStrip4.PerformLayout();
            this.Panel16.ResumeLayout(false);
            this.Panel16.PerformLayout();
            this.StatusStrip3.ResumeLayout(false);
            this.StatusStrip3.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.PanelVerInsertarSQLserver.ResumeLayout(false);
            this.StatusStrip2.ResumeLayout(false);
            this.StatusStrip2.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.PanelRepeticiones.ResumeLayout(false);
            this.PanelRepeticiones.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel9.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.PanelTABLET.ResumeLayout(false);
            this.Panel25.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel14.ResumeLayout(false);
            this.Panel13.ResumeLayout(false);
            this.Panel12.ResumeLayout(false);
            this.Panel10.ResumeLayout(false);
            this.Panel8.ResumeLayout(false);
            this.PanelBienvenida.ResumeLayout(false);
            this.PanelMvvcCsharp.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel28.ResumeLayout(false);
            this.Panel30.ResumeLayout(false);
            this.Panel34.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.Panel26.ResumeLayout(false);
            this.Panel26.PerformLayout();
            this.StatusStrip6.ResumeLayout(false);
            this.StatusStrip6.PerformLayout();
            this.Panel29.ResumeLayout(false);
            this.Panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

		}
		internal DataGridView datalistado_TABLAS;
		internal Label Label3;
		internal RichTextBox txtMostrar;
		internal Label Label2;
		internal RichTextBox txtEditar;
		internal Label Label1;
		internal RichTextBox txtInsertarSQLServer;
		internal Label labelComillas;
		internal Panel Panel1;
		internal Panel Panel2;
		internal Panel Panel3;
		internal Panel Panel6;
		internal Panel Panel4;
		internal ComboBox txtbasededatos;
		internal DataGridView datalistadoEstructura;
		internal Panel PanelTABLET;
		internal Panel Panel8;
		internal Button btnSQLSERVER;
		internal Panel Panel12;
		internal Button btnCsharp;
		internal Panel Panel10;
		internal Button btnVb;
		internal DataGridViewTextBoxColumn Tablas;
		internal Panel Panel9;
		internal RichTextBox txtEliminar;
		internal Label Label6;
		internal Panel Panel11;
		internal RichTextBox txtCrudSQLCompleto;
		internal TextBox txtcontador;
		internal Panel Panel14;
		internal Button Button5;
		internal Panel Panel13;
		internal Button Button4;
		internal RichTextBox txtCrear_procedimientos;
		internal DataGridViewTextBoxColumn Parametros;
		internal DataGridViewTextBoxColumn Tipo;
		internal DataGridViewTextBoxColumn Longitud;
		internal DataGridViewTextBoxColumn Column1;
		internal DataGridViewTextBoxColumn Column2;
		internal DataGridViewTextBoxColumn Column3;
		internal DataGridViewTextBoxColumn Column4;
		internal DataGridViewTextBoxColumn Column5;
		internal DataGridViewTextBoxColumn Column6;
		internal DataGridViewTextBoxColumn Enumeracion;
		internal DataGridViewTextBoxColumn Column8;
		internal DataGridViewTextBoxColumn Column9;
		internal DataGridViewTextBoxColumn Column10;
		internal DataGridViewTextBoxColumn Column11;
		internal DataGridViewTextBoxColumn Column12;
		internal DataGridViewTextBoxColumn Column13;
		internal DataGridViewTextBoxColumn Column14;
		internal DataGridViewTextBoxColumn Column15;
		internal DataGridViewTextBoxColumn Column16;
		internal DataGridViewTextBoxColumn Column17;
		internal DataGridViewTextBoxColumn Column18;
		internal DataGridViewTextBoxColumn Column19;
		internal TextBox txtID;
		internal Panel PanelSQLServer;
		internal Panel PanelCsharp;
		internal Panel Panelmostrar;
		internal Label Label8;
		internal RichTextBox txtMostrarCsharp;
		internal Label Label11;
		internal Panel PanelEditar;
		internal Label Label13;
		internal RichTextBox txtEditarCsharp;
		internal Panel PanelInsertar;
		internal Label Label14;
		internal RichTextBox txtInsertarCsharp;
		internal Panel PanelBienvenida;
		internal Label Label15;
		internal Panel Panel7;
		internal Button Button6;
		internal Panel Panel5;
		internal Panel Panel15;
		internal Panel PanelVb;
		internal Panel Panel20;
		internal Label Label4;
		internal RichTextBox txtMostrarVb;
		internal Label Label16;
		internal Panel Panel22;
		internal Label Label18;
		internal RichTextBox txtEditarVb;
		internal Panel Panel23;
		internal Label Label19;
		internal RichTextBox txtInsertarVb;
		internal Button Button11;
		internal Button Button12;
		internal Button Button9;
		internal Button Button10;
		internal Button Button13;
		internal Button Button14;
		internal Button Button16;
		internal Button Button15;
		internal PictureBox PictureBox1;
		internal Label Label5;
		internal Panel Panel19;
		internal Button Button17;
		internal Panel Panel25;
		internal Button Button18;
		internal Button Button20;
		internal Button Button22;
		internal Button Button21;
		internal Button Button23;
		internal Button Button25;
		internal Button Button24;
		internal CheckBox CheckBox2;
		internal CheckBox ConParametrosCsharp;
		internal Panel PanelParametros;
		internal Label Label12;
		internal DataGridView datalistadoEstructuraCONParametros;
		internal DataGridViewTextBoxColumn Parametros2;
		internal DataGridViewTextBoxColumn Tipo2;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
		internal DataGridViewTextBoxColumn Enumeracion2;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn20;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn21;
		internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn22;
		internal DataGridViewCheckBoxColumn Marcar;
		internal CheckBox CheckBox3;
		internal CheckBox EvitarRepeticionesSQLServer;
		internal Label lblRepeticionesSQLServer1;
		internal Panel PanelRepeticiones;
		internal Label Label10;
		internal StatusStrip StatusStrip1;
		internal ToolStripButton ToolStripButton1;
		internal ToolStripButton ToolStripButton2;
		internal StatusStrip StatusStrip2;
		internal ToolStripButton TSQLvolver;
		internal Panel PanelVerInsertarSQLserver;
		internal ToolStripButton TSQLver;
		internal ComboBox ComboBox1;
		internal Label Label17;
		internal RichTextBox lblRepeticionesSQLServer2;
		internal RichTextBox txtErrorSQLServer;
		internal Panel Panel27;
		internal Panel Panel28;
		internal Button btnMinimizar;
		internal Button btnCerrar;
		internal Panel Panel29;
		internal PictureBox btnRestaurar;
		internal PictureBox PictureBox5;
		internal PictureBox btnMaximizar;
		internal PictureBox PictureBox2;
		internal Label Label20;
		internal Panel Panel30;
		internal Panel Panel31;
		internal Panel Panel33;
		internal Panel Panel32;
		internal Button Button7;
		internal Panel Panel35;
		internal Panel Panel36;
		internal Panel Panel21;
		internal Panel Panel24;
		internal Panel Panel26;
		internal Panel Panel37;
		internal Panel Panel16;
		internal StatusStrip StatusStrip3;
		internal ToolStripButton ToolStripButton3;
		internal ToolStripButton ToolStripButton4;
		internal Label Label7;
		internal ToolStripButton ToolStripButton11;
		internal Panel Panel38;
		internal Panel Panel18;
		internal StatusStrip StatusStrip5;
		internal ToolStripButton ToolStripButton8;
		internal ToolStripButton ToolStripButton9;
		internal ToolStripButton ToolStripButton10;
		internal Label Label21;
		internal Panel Panel17;
		internal StatusStrip StatusStrip4;
		internal ToolStripButton ToolStripButton5;
		internal ToolStripButton ToolStripButton6;
		internal ToolStripButton ToolStripButton7;
		internal Label Label9;
		internal StatusStrip StatusStrip6;
		internal ToolStripDropDownButton ToolStripDropDownButton2;
		internal ToolStripStatusLabel ToolStripStatusLabel1;
		internal ToolStripMenuItem AcercaDeToolStripMenuItem;
		internal Button VerCodigo;
		internal Panel Panel34;
		internal Label Label22;
		internal Button Button2;
		internal PictureBox PictureBox3;
		internal Panel PanelMvvcCsharp;
		internal RichTextBox txtModeloCsharp;
	}

}