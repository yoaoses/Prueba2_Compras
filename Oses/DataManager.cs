﻿
using System.Data.SqlClient;


namespace Oses
{
    public class DataManager{
        public List<Customer> GetAllCustomers(){
            List<Customer> obtainedData = new List<Customer>();
            Connector localConn = new Connector();
            string targetTable;
            try{
                localConn.openConn();
                string query = "select * from cliente";
                SqlCommand comm = new SqlCommand(query, localConn.conn); // Aquí se utiliza localConn.conn en lugar de localConn
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()){
                    Customer dataHolder = new Customer(
                        Convert.ToInt32(reader[0]),
                        Convert.ToInt32(reader[1]),
                        Convert.ToString(reader[2])
                    );
                    obtainedData.Add(dataHolder);
                }
            }
            catch (Exception e){
                MessageBox.Show(e.Message);
            }
            finally{
                localConn.closeConn();
            }
            return obtainedData;
        }
        public List<Product> GetAllProducts()
        {
            List<Product> obtainedData = new List<Product>();
            Connector localConn = new Connector();
            string targetTable;
            try
            {
                localConn.openConn();
                string query = "select * from Producto";
                SqlCommand comm = new SqlCommand(query, localConn.conn); // Aquí se utiliza localConn.conn en lugar de localConn
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Product dataHolder = new Product(
                        Convert.ToInt32(reader[0]),
                        Convert.ToInt32(reader[1]),
                        Convert.ToString(reader[2]),
                        Convert.ToInt32(reader[3]),
                        Convert.ToInt32(reader[4])
                    );
                    obtainedData.Add(dataHolder);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                localConn.closeConn();
            }
            return obtainedData;
        }
        public bool submitSale(Transaction sale) {
            bool didItWorked = false;
            List<Product> obtainedData = new List<Product>();
            Connector localConn = new Connector();
            try
            {
                localConn.openConn();
                string query = "insert into COMPRA(numero,codigo,cantidad_comprada)  values (@numero,@codigo,@cantidad_comprada)";
                SqlCommand comm = new SqlCommand(query, localConn.conn); 
                comm.Parameters.AddWithValue("@numero", sale.clientId);
                comm.Parameters.AddWithValue("@codigo", sale.productId);
                comm.Parameters.AddWithValue("@cantidad_comprada", sale.amount );
                int rowsAffected = comm.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    didItWorked = true;
                }
                else {
                    MessageBox.Show("algo fallo en el camino ala base de datos ");
                    didItWorked = false;
                }
            }
            catch (Exception e)
            {
                didItWorked=false;
                MessageBox.Show(e.Message);
            }
            finally
            {
                localConn.closeConn();
            }
            return didItWorked;
        }
        public List<SalesRecord> getCustomerRecord(int clientNumber) {
            List<SalesRecord> obtainedData = new List<SalesRecord>();
            Connector localConn = new Connector();
            //MessageBox.Show("=>" + clientNumber);
            try
            {
                localConn.openConn();
                string query = "SELECT producto.nombre, producto.precio, COMPRA.cantidad_comprada FROM Producto JOIN COMPRA ON producto.codigo = COMPRA.codigo WHERE COMPRA.numero = @clientNumber";
                SqlCommand comm = new SqlCommand(query, localConn.conn);
                comm.Parameters.AddWithValue("@clientNumber", clientNumber);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) { 
                    SalesRecord data= new SalesRecord(Convert.ToString(reader[0]), Convert.ToInt32(reader[1]), Convert.ToInt32(reader[2]));
                    obtainedData.Add(data);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                localConn.closeConn();
            }
            return obtainedData;
        }
    }
}
