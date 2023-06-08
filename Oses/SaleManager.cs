using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oses
{
    public class SaleManager
    {
        private int _maxAmount;
        private double _tax=0.2;
        private int _unitValue;
        private int _currentAmount = 1;
        private int _taxValue;

        public SaleManager(){}

        public SaleManager(int maxAmount, int unitValue)
        {
            maxAmount = maxAmount;
            unitValue = unitValue;
        }

        public int maxAmount { get => _maxAmount; set => _maxAmount = value; }
        public double tax { get => _tax; set => _tax = value; }
        public int unitValue { get => _unitValue; set => _unitValue=value; }
        public int currentAmount { get => _currentAmount; set => _currentAmount = value; }
        public int taxValue { get => _taxValue; set => _taxValue = value; }

        public int calculateValues()
        {
            taxValue= (int)Math.Round((unitValue * currentAmount)*tax);//calcula el iva
            int currentValue = (unitValue * currentAmount) + taxValue;//calcula el valor actual a pagar

            return currentValue;
        }
        public int addOne() {
            currentAmount++;
            calculateValues();
            return currentAmount;
        }

        public int subsOne() {
            currentAmount--;
            calculateValues();
            return currentAmount;
        }
        public void reset() { 
            maxAmount=0;
            unitValue=0;
            taxValue=0;
            currentAmount=0;
        }
    }
}
