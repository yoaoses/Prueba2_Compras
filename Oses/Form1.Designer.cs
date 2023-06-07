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
            grpClient = new GroupBox();
            lblNumClient = new Label();
            label5 = new Label();
            lblClientName = new Label();
            label3 = new Label();
            lblPrice = new Label();
            label8 = new Label();
            lblStock = new Label();
            label6 = new Label();
            lblProducto = new Label();
            label4 = new Label();
            grpProduct = new GroupBox();
            lblProductCode = new Label();
            label9 = new Label();
            grpCurrentSale = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTotal = new Label();
            label11 = new Label();
            lblTax = new Label();
            lblNoTax = new Label();
            label10 = new Label();
            label12 = new Label();
            btnAdd = new Button();
            btnSubs = new Button();
            label7 = new Label();
            txtAmount = new TextBox();
            btnRst = new Button();
            btnSubmitSale = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpClient.SuspendLayout();
            grpProduct.SuspendLayout();
            grpCurrentSale.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            // grpClient
            // 
            grpClient.Controls.Add(button1);
            grpClient.Controls.Add(lblNumClient);
            grpClient.Controls.Add(label5);
            grpClient.Controls.Add(lblClientName);
            grpClient.Controls.Add(label3);
            grpClient.Location = new Point(360, 22);
            grpClient.Name = "grpClient";
            grpClient.Size = new Size(428, 77);
            grpClient.TabIndex = 5;
            grpClient.TabStop = false;
            grpClient.Text = "Datos venta";
            grpClient.EnabledChanged += grpClient_EnabledChanged;
            // 
            // lblNumClient
            // 
            lblNumClient.AutoSize = true;
            lblNumClient.Location = new Point(83, 50);
            lblNumClient.Name = "lblNumClient";
            lblNumClient.Size = new Size(86, 15);
            lblNumClient.TabIndex = 3;
            lblNumClient.Text = "numeroCliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 50);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 2;
            label5.Text = "Numero:";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(88, 24);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(86, 15);
            lblClientName.TabIndex = 1;
            lblClientName.Text = "nombreCliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 24);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Datos cliente:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(87, 55);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(81, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "preciounitario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 55);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 6;
            label8.Text = "Precio neto:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(309, 55);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(97, 15);
            lblStock.TabIndex = 5;
            lblStock.Text = "unidadesEnStock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 55);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 4;
            label6.Text = "Existencias:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(87, 25);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(98, 15);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "nombreProducto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 25);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Producto:";
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(lblProductCode);
            grpProduct.Controls.Add(label9);
            grpProduct.Controls.Add(lblPrice);
            grpProduct.Controls.Add(label8);
            grpProduct.Controls.Add(label4);
            grpProduct.Controls.Add(lblStock);
            grpProduct.Controls.Add(lblProducto);
            grpProduct.Controls.Add(label6);
            grpProduct.Location = new Point(360, 105);
            grpProduct.Name = "grpProduct";
            grpProduct.Size = new Size(427, 79);
            grpProduct.TabIndex = 6;
            grpProduct.TabStop = false;
            grpProduct.Text = "Datos Producto";
            grpProduct.EnabledChanged += grpProduct_EnabledChanged;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(309, 25);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(76, 15);
            lblProductCode.TabIndex = 9;
            lblProductCode.Text = "codProducto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(254, 25);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 8;
            label9.Text = "Código:";
            // 
            // grpCurrentSale
            // 
            grpCurrentSale.Controls.Add(tableLayoutPanel1);
            grpCurrentSale.Controls.Add(btnAdd);
            grpCurrentSale.Controls.Add(btnSubs);
            grpCurrentSale.Controls.Add(label7);
            grpCurrentSale.Controls.Add(txtAmount);
            grpCurrentSale.Location = new Point(360, 190);
            grpCurrentSale.Name = "grpCurrentSale";
            grpCurrentSale.Size = new Size(428, 87);
            grpCurrentSale.TabIndex = 7;
            grpCurrentSale.TabStop = false;
            grpCurrentSale.Text = "Esta Venta";
            grpCurrentSale.EnabledChanged += grpCurrentSale_EnabledChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.Controls.Add(lblTotal, 1, 2);
            tableLayoutPanel1.Controls.Add(label11, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTax, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNoTax, 1, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(label12, 0, 1);
            tableLayoutPanel1.Location = new Point(237, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(170, 46);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(77, 31);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "total+iva";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 4;
            label11.Text = "neto:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(77, 15);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(22, 15);
            lblTax.TabIndex = 7;
            lblTax.Text = "iva";
            // 
            // lblNoTax
            // 
            lblNoTax.AutoSize = true;
            lblNoTax.Location = new Point(77, 0);
            lblNoTax.Name = "lblNoTax";
            lblNoTax.Size = new Size(48, 15);
            lblNoTax.TabIndex = 6;
            lblNoTax.Text = "valNeto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 31);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 3;
            label10.Text = "Total venta:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 15);
            label12.Name = "label12";
            label12.Size = new Size(27, 15);
            label12.TabIndex = 5;
            label12.Text = "IVA:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(180, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubs
            // 
            btnSubs.Location = new Point(88, 35);
            btnSubs.Name = "btnSubs";
            btnSubs.Size = new Size(30, 23);
            btnSubs.TabIndex = 1;
            btnSubs.Text = "-";
            btnSubs.UseVisualStyleBackColor = true;
            btnSubs.Click += btnSubs_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 38);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 0;
            label7.Text = "Unidades:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(124, 35);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(50, 23);
            txtAmount.TabIndex = 0;
            txtAmount.Text = "1";
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // btnRst
            // 
            btnRst.Location = new Point(638, 376);
            btnRst.Name = "btnRst";
            btnRst.Size = new Size(127, 23);
            btnRst.TabIndex = 8;
            btnRst.Text = "Limpiar / Cancelar";
            btnRst.UseVisualStyleBackColor = true;
            btnRst.Click += btnRst_Click;
            // 
            // btnSubmitSale
            // 
            btnSubmitSale.Location = new Point(639, 294);
            btnSubmitSale.Name = "btnSubmitSale";
            btnSubmitSale.Size = new Size(126, 23);
            btnSubmitSale.TabIndex = 9;
            btnSubmitSale.Text = "Confirmar Compra";
            btnSubmitSale.UseVisualStyleBackColor = true;
            btnSubmitSale.Click += btnSubmitSale_Click;
            // 
            // button1
            // 
            button1.Location = new Point(261, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 423);
            Controls.Add(btnSubmitSale);
            Controls.Add(btnRst);
            Controls.Add(grpCurrentSale);
            Controls.Add(grpProduct);
            Controls.Add(grpClient);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpClient.ResumeLayout(false);
            grpClient.PerformLayout();
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            grpCurrentSale.ResumeLayout(false);
            grpCurrentSale.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private GroupBox grpClient;
        private Label lblClientName;
        private Label label3;
        private Label lblProducto;
        private Label label4;
        private Label label8;
        private Label lblStock;
        private Label label6;
        private Label lblPrice;
        private Label lblNumClient;
        private Label label5;
        private GroupBox grpProduct;
        private Label lblProductCode;
        private Label label9;
        private GroupBox grpCurrentSale;
        private TextBox txtAmount;
        private Button btnAdd;
        private Button btnSubs;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblNoTax;
        private Label lblTax;
        private Label lblTotal;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRst;
        private Button btnSubmitSale;
        private Button button1;
    }
}