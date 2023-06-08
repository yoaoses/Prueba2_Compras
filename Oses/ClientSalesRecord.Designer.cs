namespace Oses
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
            product = new DataGridViewTextBoxColumn();
            totalValue = new DataGridViewTextBoxColumn();
            salesRecordBindingSource = new BindingSource(components);
            groupBox3 = new GroupBox();
            txtClientSearch = new TextBox();
            label3 = new Label();
            lstCustomers = new ListBox();
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
            groupBox1.Size = new Size(317, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // lblNumClient
            // 
            lblNumClient.AutoSize = true;
            lblNumClient.Location = new Point(120, 54);
            lblNumClient.Name = "lblNumClient";
            lblNumClient.Size = new Size(88, 15);
            lblNumClient.TabIndex = 3;
            lblNumClient.Text = "NumeroCliente";
            // 
            // lbln
            // 
            lbln.AutoSize = true;
            lbln.Location = new Point(60, 54);
            lbln.Name = "lbln";
            lbln.Size = new Size(54, 15);
            lbln.TabIndex = 2;
            lbln.Text = "Numero:";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(120, 28);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(88, 15);
            lblClientName.TabIndex = 1;
            lblClientName.Text = "NombreCliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(182, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(317, 190);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Historial de Ventas (IVA incluido)";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { product, totalValue });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(311, 168);
            dataGridView1.TabIndex = 0;
            // 
            // product
            // 
            product.HeaderText = "Producto";
            product.Name = "product";
            product.ReadOnly = true;
            // 
            // totalValue
            // 
            totalValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalValue.HeaderText = "importe Total";
            totalValue.Name = "totalValue";
            totalValue.ReadOnly = true;
            // 
            // salesRecordBindingSource
            // 
            salesRecordBindingSource.DataSource = typeof(SalesRecord);
            // 
            // groupBox3
            // 
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
            // txtClientSearch
            // 
            txtClientSearch.Location = new Point(6, 42);
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
            label3.Size = new Size(98, 15);
            label3.TabIndex = 1;
            label3.Text = "Búsqueda Rapida";
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(6, 73);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(143, 199);
            lstCustomers.TabIndex = 0;
            lstCustomers.SelectedIndexChanged += lstCustomers_SelectedIndexChanged;
            // 
            // ClientSalesRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 300);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ClientSalesRecord";
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
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn totalValue;
        private GroupBox groupBox3;
        private TextBox txtClientSearch;
        private Label label3;
        private ListBox lstCustomers;
    }
}