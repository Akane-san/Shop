using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Notebook : Product
    {
        private int _countOfPages;
        public Notebook(int id, string name, int price, int countOfPages) : base(id, name, price)
        {
            CountOfPages = countOfPages;
        }

        public int CountOfPages
        {
            get { return _countOfPages; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The count of pages must be positive");
                }
                if (value > 1000)
                {
                    throw new Exception("The count of pages is too big");
                }
                _countOfPages = value;
            }
        }

        public override bool ContainsTerm(string term)
        {
            return Name.Contains(term);
        }

        public override string ToString()
        {
            return String.Format(ID + '\n' + Name + '\n' + Price.ToString() + '\n' +  CountOfPages.ToString());
        }
    }
}
