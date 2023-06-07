namespace Oses
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCustomers = new ListBox();
            lstProducts = new ListBox();
            groupBox1 = new GroupBox();
            txtClientSearch = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtProductSearch = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            lblDatosCliente = new Label();
            label3 = new Label();
            label4 = new Label();
            lblProducto = new Label();
            label6 = new Label();
            lblStock = new Label();
            label8 = new Label();
            lblPrice = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(6, 73);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(143, 304);
            lstCustomers.TabIndex = 0;
            lstCustomers.SelectedIndexChanged += lstCustomers_SelectedIndexChanged;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 15;
            lstProducts.Location = new Point(6, 73);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(158, 304);
            lstProducts.TabIndex = 1;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtClientSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lstCustomers);
            groupBox1.Location = new Point(13, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 383);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes";
            // 
            // txtClientSearch
            // 
            txtClientSearch.Location = new Point(6, 42);
            txtClientSearch.Name = "txtClientSearch";
            txtClientSearch.Size = new Size(143, 23);
            txtClientSearch.TabIndex = 2;
            txtClientSearch.Click += txtClientSearch_Click;
            txtClientSearch.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Búsqueda Rapida";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtProductSearch);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lstProducts);
            groupBox2.Location = new Point(184, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(170, 383);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos";
            // 
            // txtProductSearch
            // 
            txtProductSearch.Location = new Point(6, 42);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(158, 23);
            txtProductSearch.TabIndex = 3;
            txtProductSearch.Click += txtProductSearch_Click;
            txtProductSearch.TextChanged += txtProductSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "Búsqueda Rapida";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblPrice);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(lblStock);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(lblProducto);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(lblDatosCliente);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(360, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(428, 104);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos venta";
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Location = new Point(103, 24);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(73, 15);
            lblDatosCliente.TabIndex = 1;
            lblDatosCliente.Text = "datosCliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 23);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Datos cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 50);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Producto:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(103, 50);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(85, 15);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "datosProducto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 73);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 4;
            label6.Text = "Existencias:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(103, 73);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(97, 15);
            lblStock.TabIndex = 5;
            lblStock.Text = "unidadesEnStock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 73);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 6;
            label8.Text = "Precio:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(255, 73);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(81, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "preciounitario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstCustomers;
        private ListBox lstProducts;
        private GroupBox groupBox1;
        private TextBox txtClientSearch;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtProductSearch;
        private Label label2;
        private GroupBox groupBox3;
        private Label lblDatosCliente;
        private Label label3;
        private Label lblProducto;
        private Label label4;
        private Label label8;
        private Label lblStock;
        private Label label6;
        private Label lblPrice;
    }
}