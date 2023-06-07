using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oses
{
    internal class Transaction
    {
        private int _amount;
        private int _clientId;
        private int _productId;

        public Transaction(int amount, int clientId, int productId)
        {
            _amount = amount;
            _clientId = clientId;
            _productId = productId;
        }

        public int amount { get => _amount; set => _amount = value; }
        public int clientId { get => _clientId; set => _clientId = value; }
        public int productId { get => _productId; set => _productId = value; }
    }
}
