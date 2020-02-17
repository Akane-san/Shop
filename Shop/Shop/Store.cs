using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Shop
{
    public class Store
    {
        private List<Product> _products;

        public Store()
        {
            _products = new List<Product>();
        }

        public int Count()
        {
            return _products.Count;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(int ID)
        {
            for (int i = 0; i < _products.Count; i++)
                if (_products[i].ID == ID)
                {
                    _products.Remove(_products[i]);
                }
        }

        public List<Product> Search(string searchCondition)
        {
            var suitableProducts = new List<Product>();

            foreach (Product product in _products)
            {
                if (product.ContainsTerm(searchCondition))
                {
                    suitableProducts.Add(product);
                }
            }
            return suitableProducts;
        }

        public Product GetProduct(int index)
        {
            if (index < 0) throw new ArgumentException("The index must be positive");
            if (index >= _products.Count) throw new ArgumentException("The index must be less then count of products");
            return _products[index];
        }

        public void Sort()
        {
            _products.Sort();
        }

        public void Sort(IComparer<Product> comparer)
        {
            _products.Sort(comparer);
        }
    }
}
