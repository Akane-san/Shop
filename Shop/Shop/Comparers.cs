using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class NameComparer : IComparer<Product>
    {
        public int Compare(Product product1, Product product2)
        {
            return product1.Name.CompareTo(product2.Name);
        }
    }

    public class PriceComparer : IComparer<Product>
    {
        public int Compare(Product product1, Product product2)
        {
            return product1.Price.CompareTo(product2.Price);
        }
    }
}
