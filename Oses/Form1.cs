using System.Linq;
using System.Net.Http.Headers;

namespace Oses
{
    public partial class Form1 : Form
    {
        DataManager dataHandler = new DataManager();
        List<Customer> clientsData = new List<Customer>();
        List<Product> productData = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clientsData = dataHandler.GetAllCustomers();
            productData = dataHandler.GetAllProducts();
            resetFields();
        }
        private void resetFields()
        {
            txtClientSearch.Text = string.Empty;
            loadCustomers(clientsData);
            loadProducts(productData);
            lblDatosCliente.Text = string.Empty;
            lblPrice.Text = string.Empty;
            lblStock.Text= string.Empty;
            lblProducto.Text = string.Empty;
        }
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
        private void txtClientSearch_Click(object sender, EventArgs e)
        {
            txtClientSearch.SelectAll();
        }
        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtClientSearch.Text.Length >= 3)
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
        private void txtProductSearch_Click(object sender, EventArgs e)
        {
            txtProductSearch.SelectAll();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer result = clientsData.FirstOrDefault(client => client.name == lstCustomers.SelectedItem);
            lblDatosCliente.Text = result.name + ", " + result.number;
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product result = productData.FirstOrDefault(item => item.name == lstProducts.SelectedItem);
            lblProducto.Text = result.name + ", " + result.barcode;
            lblPrice.Text = result.price + " c/u";
            lblStock.Text = result.stock + " unidades";
        }
    }
}