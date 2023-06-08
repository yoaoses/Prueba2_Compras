
using System.Data;



namespace Oses
{
    public partial class ClientSalesRecord : Form
    {
        private List<SalesRecord> salesRecords;
        private Customer customerData;
        private List<Customer> customersList;
        private DataManager dataHandler = new DataManager();
        public ClientSalesRecord(Customer customerData, List<Customer> customers)
        {
            this.customerData = customerData;
            this.customersList = customers;
            InitializeComponent();
        }

        private void ClientSalesRecord_Load(object sender, EventArgs e)
        {
            //resetFields();
            loadCustomers(customersList);
            if (customerData != null)
            {
                loadCustomerData(customerData);
                //getAndsetSalesData();
                lstCustomers.SelectedItem = customerData.name;
            }
        }

        private void loadSalesRecord(List<SalesRecord> salesRecords)
        {
            dataGridView1.Rows.Clear();
            foreach (SalesRecord sale in salesRecords)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, sale.productName, sale.totalValue);
                dataGridView1.Rows.Add(row);
            }
        }
        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer result = customersList.FirstOrDefault(client => client.name == lstCustomers.SelectedItem.ToString());
            if (result != null)
            {
                lblClientName.Text = result.name;
                lblNumClient.Text = Convert.ToString(result.number);
                getAndsetSalesData();


            }

        }
        public void getAndsetSalesData()
        {
            List<SalesRecord> obtainedData = dataHandler.getCustomerRecord(Convert.ToInt32(lblNumClient.Text));
            loadSalesRecord(obtainedData);
        }
        private void txtClientSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtClientSearch.Text.Length >= 3)
            {
                List<Customer> filtered = new List<Customer>();
                filtered = customersList.Where(item => item.name.StartsWith(Convert.ToString(txtClientSearch.Text), StringComparison.OrdinalIgnoreCase)).ToList();
                if (filtered.Count > 0)
                {
                    loadCustomers(filtered);
                }
            }
            else
            {
                loadCustomers(customersList);
            }
        }
        private void loadCustomerData(Customer customerData)
        {

            lblClientName.Text = customerData.name;
            lblNumClient.Text = Convert.ToString(customerData.number);
            //lstCustomers.SelectedItem = customerData.name;
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

        private void txtClientNumber_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtClientNumber.Text.Trim();
            if (searchText.Length > 0 && int.TryParse(searchText, out int searchNumber))
            {
                List<Customer> filtered = customersList.Where(item => item.number.ToString().StartsWith(searchText)).ToList();
                if (filtered.Count > 0)
                {
                    loadCustomers(filtered);
                    //loadCustomerData(filtered[0]);
                }
            }
            else
            {
                loadCustomers(customersList);
            }

        }
    }
}
