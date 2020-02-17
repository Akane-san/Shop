using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public abstract class Product : IComparable<Product>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private int _price;

        public Product(int id, string name, int price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The price must be positive");
                }
                _price = value;
            }
        }

        public void ChangePrice(int change)
        {
            if (change + Price < 0) throw new ArgumentException("The change must be bigger than -price");
            Price += change;
        }

        public abstract bool ContainsTerm(string term);

        public int CompareTo(Product other)
        {
            return ID.CompareTo(other.ID);
        }
    }
}
