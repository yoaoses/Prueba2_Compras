

namespace Oses
{
    public class Customer
    {
        private int _id;
        private int _number;
        private string _name;

        public Customer()
        {
        }

        public Customer(int incommingId, int incommingnumber, string incommingname)
        {
            id = incommingId;
            number = incommingnumber;
            name = incommingname;
        }

        public int id { get => _id; set => _id = value; }
        public int number { get => _number; set => _number = value; }
        public string name { get => _name; set => _name = value; }

        public void printData() {
            MessageBox.Show(id + ", " + number + ", " + name);
        }
    }
}
