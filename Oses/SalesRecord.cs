using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oses
{
    public class SalesRecord
    {
        private string _productName;
        private int _saleValue;
        private int _totalValue;
        private int _amount;

        public SalesRecord()
        {
        }

        public SalesRecord(string productName, int saleValue,int amount)
        {
            int calc =setTotalValue(amount,saleValue);
            this.productName = productName;
            this.saleValue = saleValue;
            this.amount = amount;
            this.totalValue = calc;
           
        }

        public string productName { get => _productName; set => _productName = value; }
        public int saleValue { get => _saleValue; set => _saleValue = value; }
        public int totalValue { get => _totalValue; set => _totalValue = value; }
        public int amount { get => _amount; set => _amount = value; }

        private int setTotalValue(int amount, int saleValue) {
            return amount * saleValue;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
