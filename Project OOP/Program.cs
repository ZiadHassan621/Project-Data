using System.Security.Cryptography.X509Certificates;

namespace Project_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StackList myData = new StackList();

            myData.push("prod1", "Test", 5,20, 50);
            //mydata2.push("Ziad", "Khara", 6, 789, 80, 50);
            //mydata2.Display();

            myData.push("prod2", "Test", 5, 20, 50);

            myData.push("prod3", "Test", 5, 20, 50);

            myData.Display();

        }



    }
    class Product
    {
        private string name;
        private string category;
        private int quantity;
        private int iD;
        private double[] price = new double[2];
        private double TotalPrice;
       // private int generateid = 11110;


        public Product(string _name,string _category,int _quantity,int _iD , double _cost,double _profit)
        {
            Name = _name;
            Category = _category;
            quantity = _quantity;
            iD = _iD;
            Cost = _cost;
            Profit = _profit;
        }
        public string Name
        {
            get
            { return name; }
            set
            {    
                if (value != "")
                    name = value;
            }
        }
        public string Category
        {
            get
            { return category; }
            set
            {
                if (value != "")
                    category = value;
            }
        }
        public double Cost
        {
            get { return price[0]; }
            set
            {
                if(value > 0)
                    price[0] = value;
            }
        }
        public double Profit
        {
            get { return price[1]; }
            set
            {
                if (value >= 0)
                    price[1] = value;
            }
        }
        public double totalPrice()
        {
            TotalPrice = Cost + Profit;
            return TotalPrice;
        }
       
        public void Display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Category);
            Console.WriteLine(quantity);
            Console.WriteLine(iD);
            Console.WriteLine(totalPrice());
        }

    }
}