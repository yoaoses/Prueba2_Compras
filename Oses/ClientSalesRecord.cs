using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Oses
{
    public partial class ClientSalesRecord : Form
    {
        private List<SalesRecord> salesRecords;
        private Customer customerData;
        private List<Customer> customersList;
        private DataManager dataHandler;
        public ClientSalesRecord(List<SalesRecord> salesRecords, Customer customerData, List<Customer> customers)
        {
            this.salesRecords = salesRecords;
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
                loadSalesRecord(salesRecords);
                lstCustomers.SelectedItem = customerData.name;
            }
        }

        private void loadSalesRecord(List<SalesRecord> salesRecords) {
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
                result.printData();
                lblClientName.Text = result.name;
                lblNumClient.Text = Convert.ToString(result.number);
                List<SalesRecord> clientRecord=dataHandler.getCustomerRecord(result.number);
            }
   
        }

        private void txtClientSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtClientSearch.Text.Length >= 3)
            {
                List<Customer> filtered = new List<Customer>();
                filtered = customersList.Where(item => item.name.StartsWith(Convert.ToString(txtClientSearch.Text), StringComparison.OrdinalIgnoreCase)).ToList();
                if (filtered.Count > 0)
                {
                    loadCustomerData(filtered[0]);
                }
            }
            else
            {
                loadCustomers(customersList);
            }
        }
        private void loadCustomerData(Customer customerData) { 
            lblClientName.Text = customerData.name;
            lblNumClient.Text = Convert.ToString(customerData.number);
            lstCustomers.SelectedItem = customerData.name;
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
    }
}
