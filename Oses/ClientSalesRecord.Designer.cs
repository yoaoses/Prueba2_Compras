﻿namespace Oses
{
    partial class ClientSalesRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            lblNumClient = new Label();
            lbln = new Label();
            lblClientName = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            salesRecordBindingSource = new BindingSource(components);
            groupBox3 = new GroupBox();
            txtClientNumber = new TextBox();
            label2 = new Label();
            txtClientSearch = new TextBox();
            label3 = new Label();
            lstCustomers = new ListBox();
            product = new DataGridViewTextBoxColumn();
            totalValue = new DataGridViewTextBoxColumn();
            taxCol = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesRecordBindingSource).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNumClient);
            groupBox1.Controls.Add(lbln);
            groupBox1.Controls.Add(lblClientName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(182, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 53);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // lblNumClient
            // 
            lblNumClient.AutoSize = true;
            lblNumClient.Location = new Point(289, 24);
            lblNumClient.Name = "lblNumClient";
            lblNumClient.Size = new Size(88, 15);
            lblNumClient.TabIndex = 3;
            lblNumClient.Text = "NumeroCliente";
            // 
            // lbln
            // 
            lbln.AutoSize = true;
            lbln.Location = new Point(229, 24);
            lbln.Name = "lbln";
            lbln.Size = new Size(54, 15);
            lbln.TabIndex = 2;
            lbln.Text = "Numero:";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(82, 24);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(88, 15);
            lblClientName.TabIndex = 1;
            lblClientName.Text = "NombreCliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(182, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 217);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Historial de Ventas (IVA incluido)";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { product, totalValue, taxCol });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(394, 195);
            dataGridView1.TabIndex = 0;
            // 
            // salesRecordBindingSource
            // 
            salesRecordBindingSource.DataSource = typeof(SalesRecord);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtClientNumber);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtClientSearch);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lstCustomers);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(155, 276);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Clientes";
            // 
            // txtClientNumber
            // 
            txtClientNumber.Location = new Point(6, 42);
            txtClientNumber.Name = "txtClientNumber";
            txtClientNumber.Size = new Size(143, 23);
            txtClientNumber.TabIndex = 4;
            txtClientNumber.TextChanged += txtClientNumber_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 3;
            label2.Text = "Busqueda por Nombre";
            // 
            // txtClientSearch
            // 
            txtClientSearch.Location = new Point(6, 95);
            txtClientSearch.Name = "txtClientSearch";
            txtClientSearch.Size = new Size(143, 23);
            txtClientSearch.TabIndex = 2;
            txtClientSearch.TextChanged += txtClientSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 1;
            label3.Text = "Ingrese nº de Cliente";
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(6, 133);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(143, 139);
            lstCustomers.TabIndex = 0;
            lstCustomers.SelectedIndexChanged += lstCustomers_SelectedIndexChanged;
            // 
            // product
            // 
            product.Frozen = true;
            product.HeaderText = "Producto";
            product.Name = "product";
            product.ReadOnly = true;
            // 
            // totalValue
            // 
            totalValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalValue.Frozen = true;
            totalValue.HeaderText = "Total neto";
            totalValue.Name = "totalValue";
            totalValue.ReadOnly = true;
            totalValue.Width = 168;
            // 
            // taxCol
            // 
            taxCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            taxCol.HeaderText = "Total IVA";
            taxCol.Name = "taxCol";
            taxCol.ReadOnly = true;
            // 
            // ClientSalesRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 300);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClientSalesRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClientSalesRecord";
            Load += ClientSalesRecord_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesRecordBindingSource).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNumClient;
        private Label lbln;
        private Label lblClientName;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private BindingSource salesRecordBindingSource;
        private GroupBox groupBox3;
        private TextBox txtClientSearch;
        private Label label3;
        private ListBox lstCustomers;
        private TextBox txtClientNumber;
        private Label label2;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn totalValue;
        private DataGridViewTextBoxColumn taxCol;
    }
}