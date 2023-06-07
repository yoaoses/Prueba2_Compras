using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oses{
    internal class Product{
        private int _id;
        private int _barcode;
        private string _name;
        private int _stock;
        private int _price;

        public Product(int incommingId, int incommingBarcode, string incommingName, int incommingStock, int incommingPrice){
            id = incommingId;
            barcode = incommingBarcode;
            name = incommingName;
            stock = incommingStock;
            price = incommingPrice;
        }

        public int id { get => _id; set => _id = value; }
        public int barcode { get => _barcode; set => _barcode = value; }
        public string name { get => _name; set => _name = value; }
        public int price { get => _price; set => _price = value; }
        public int stock { get => _stock; set => _stock = value; }

        public void addStock(int amount) { 
            this.stock += amount;
        }
        public void subsStock(int amount) { 
            this.stock -= amount;
        }
    }
}
