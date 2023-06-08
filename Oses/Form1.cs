//using System.Linq;
//using System.Net.Http.Headers;

namespace Oses
{
    public partial class Form1 : Form
    {
        DataManager dataHandler = new DataManager();
        List<Customer> clientsData = new List<Customer>();
        List<Product> productData = new List<Product>();
        SaleManager currentSale = new SaleManager();
        Customer currentCustomer = new Customer();
        Transaction saleData = new Transaction();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clientsData = dataHandler.GetAllCustomers();
            productData = dataHandler.GetAllProducts();
            resetFields("");
        }

        //--controladores de listas
        private void loadCustomers(List<Customer> clients)
        {
            lstCustomers.Items.Clear();

            if (clients.Count == 0)
            {
                MessageBox.Show("no hay Clientes ingresados");
            }
            else
            {
                foreach (Customer client in clients)
                {
                    lstCustomers.Items.Add(client.name);
                }
            }
        }
        private void loadProducts(List<Product> products)
        {
            lstProducts.Items.Clear();
            if (products.Count == 0)
            {
                MessageBox.Show("No hay productos ingresados");
            }
            else
            {
                foreach (Product item in products)
                {
                    lstProducts.Items.Add(item.name);
                }
            }
        }
        private void txtClientSearch_Click(object sender, EventArgs e)
        {
            txtClientSearch.SelectAll();
        }
        private void txtProductSearch_Click(object sender, EventArgs e)
        {
            txtProductSearch.SelectAll();
        }
        //--------------------------

        //--escalabilidad--
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtClientSearch.Text.Length >= 3)
            {
                List<Customer> filtered = new List<Customer>();
                filtered = clientsData.Where(item => item.name.StartsWith(Convert.ToString(txtClientSearch.Text), StringComparison.OrdinalIgnoreCase)).ToList();
                if (filtered.Count > 0)
                {
                    loadCustomers(filtered);
                }
            }
            else
            {
                loadCustomers(clientsData);
            }
        }
        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtProductSearch.Text.Length >= 3)
            {
                List<Product> filtered = new List<Product>();
                filtered = productData.Where(item => item.name.StartsWith(Convert.ToString(txtProductSearch.Text), StringComparison.OrdinalIgnoreCase)).ToList();
                if (filtered.Count > 0)
                {
                    loadProducts(filtered);
                }
            }
            else
            {
                loadProducts(productData);
            }
        }
        private void txtClientNumber_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtClientNumber.Text.Trim();
            if (searchText.Length > 0 && int.TryParse(searchText, out int searchNumber))
            {
                List<Customer> filtered = clientsData.Where(item => item.number.ToString().StartsWith(searchText)).ToList();
                if (filtered.Count > 0)
                {
                    loadCustomers(filtered);
                    //loadCustomerData(filtered[0]);
                }
            }
            else
            {
                loadCustomers(clientsData);
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtProdCode.Text.Trim();
            if (searchText.Length > 0 && int.TryParse(searchText, out int searchNumber))
            {
                List<Product> filtered = productData.Where(item => item.barcode.ToString().StartsWith(searchText)).ToList();
                if (filtered.Count > 0)
                {
                    loadProducts(filtered);
                    //loadCustomerData(filtered[0]);
                }
            }
            else
            {
                loadProducts(productData);
            }
        }

        //-----------------

        //--comportamientos listboxes--
        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpClient.Enabled = true;
            Customer result = clientsData.FirstOrDefault(client => client.name == lstCustomers.SelectedItem);
            currentCustomer = result;
            lblClientName.Text = result.name;
            lblNumClient.Text = Convert.ToString(result.number);
            saleData.clientId = result.number;
            if (lstProducts.SelectedItems.Count > 0)
            {
                calcSale();
            }
        }
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpProduct.Enabled = true;
            Product result = productData.FirstOrDefault(item => item.name == lstProducts.SelectedItem);
            lblProducto.Text = result.name;
            lblProductCode.Text = Convert.ToString(result.barcode);
            lblPrice.Text = result.price + " c/u";
            lblStock.Text = result.stock + " unidades";

            currentSale.unitValue = result.price;
            currentSale.maxAmount = result.stock;
            saleData.productId = result.barcode;
            if (lstCustomers.SelectedItems.Count > 0)
            {
                calcSale();
            }
        }
        //-----------------------------

        //-- habilitar venta solo si cliente y producto estan seleccionados
        //-- sacado de https://social.msdn.microsoft.com/Forums/es-ES/245e97e9-0dc5-4099-8fe8-db02ba993964/c-como-hacer-que-un-groupbox-en-c-no-se-active-hasta-que-se-cumpla-una-condicin-?forum=vcses
        //-- evento de -> propiedades de groupbox-> eventos -> EnabledChanged
        private void grpClient_EnabledChanged(object sender, EventArgs e)
        {
            if (grpClient.Enabled && grpProduct.Enabled)
            {
                grpCurrentSale.Enabled = true;
                txtAmount.Text = "1";
                //calcSale();
            }
            else
            {
                grpCurrentSale.Enabled = false;
            }
        }
        private void grpProduct_EnabledChanged(object sender, EventArgs e)
        {
            if (grpClient.Enabled && grpProduct.Enabled)
            {
                grpCurrentSale.Enabled = true;
                txtAmount.Text = "1";
                //calcSale();
            }
            else
            {
                grpCurrentSale.Enabled = false;
            }
        }
        private void grpCurrentSale_EnabledChanged(object sender, EventArgs e)
        {
            txtAmount.Text = "1";
            //calcSale();
        }
        private void calcSale()
        {
            currentSale.currentAmount = Convert.ToInt32(txtAmount.Text);
            currentSale.calculateValues();

            setSaleLabels();
        }
        //--------------------------------------------------------------------

        //---botones---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtAmount.Text) < currentSale.maxAmount)
            {
                //btnAdd.Enabled = true;
                txtAmount.Text = Convert.ToString(currentSale.addOne());
                setSaleLabels();
            }
            else
            {
                MessageBox.Show("Monto sobrepasado, existencias = " + currentSale.maxAmount);
                //btnAdd.Enabled = false;
            }
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtAmount.Text) > 1)
            {
                //btnSubs.Enabled = true;
                txtAmount.Text = Convert.ToString(currentSale.subsOne());
                setSaleLabels();
            }
            else
            {
                //btnSubs.Enabled = false;
            }
        }
        //------------

        //-- utilidades UI --
        private void setSaleLabels()
        {
            lblTotal.Text = Convert.ToString(currentSale.calculateValues());
            lblNoTax.Text = Convert.ToString(currentSale.unitValue * currentSale.currentAmount);
            lblTax.Text = currentSale.taxValue + " ( 20% )";
        }
        private void resetFields(string action)
        {
            //--resetData--
            if (action == "resetData")
            {
                clientsData.Clear();
                productData.Clear();
                clientsData = dataHandler.GetAllCustomers();
                productData = dataHandler.GetAllProducts();
                currentSale.reset();
                saleData.reset();
            }
            //------------
            txtClientSearch.Text = string.Empty;
            txtClientNumber.Text= string.Empty;
            txtProductSearch.Text = string.Empty;
            txtProdCode.Text= string.Empty; 
            loadCustomers(clientsData);
            loadProducts(productData);

            grpClient.Enabled = false;
            lblNumClient.Text = string.Empty;
            lblClientName.Text = string.Empty;

            grpProduct.Enabled = false;
            lblPrice.Text = string.Empty;
            lblStock.Text = string.Empty;
            lblProducto.Text = string.Empty;
            lblProductCode.Text = string.Empty;

            grpCurrentSale.Enabled = false;
            lblTotal.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblNoTax.Text = string.Empty;
            txtAmount.TextChanged -= txtAmount_TextChanged;//desactivar el evento textchange para evitar que se ejecute el codigo
            txtAmount.Text = "1";
            txtAmount.TextChanged += txtAmount_TextChanged;//reactivar el evento 
        }
        private void btnRst_Click(object sender, EventArgs e)
        {
            resetFields("resetData");
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtAmount.Text) > currentSale.maxAmount)
            {
                txtAmount.Text = Convert.ToString(currentSale.maxAmount);
                calcSale();
            }
        }

        private void btnSubmitSale_Click(object sender, EventArgs e)
        {
            saleData.amount = Convert.ToInt32(txtAmount.Text);
            if (dataHandler.submitSale(saleData))
            {
                MessageBox.Show("Venta Registrada: ");
                resetFields("resetData");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<SalesRecord> obtainedData = dataHandler.getCustomerRecord(Convert.ToInt32(lblNumClient.Text));
            ClientSalesRecord SalesRecord = new ClientSalesRecord(currentCustomer, clientsData);
            SalesRecord.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientSalesRecord SalesRecord = new ClientSalesRecord(null, clientsData);
            SalesRecord.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProdCode_Click(object sender, EventArgs e)
        {
            txtProdCode.SelectAll();
        }

        private void txtClientNumber_Click(object sender, EventArgs e)
        {
            txtClientNumber.SelectAll();
        }

        private void txtAmount_Click(object sender, EventArgs e)
        {
            txtAmount.SelectAll();
        }


        //------------------


    }
}