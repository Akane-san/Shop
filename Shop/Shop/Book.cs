using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Book : Product
    {
        public string Genre { get; set; }
        public string Autor { get; set; }
        private int _year;

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The year must be positive");
                }
                if (value > DateTime.Now.Year)
                {
                    throw new Exception("The year must be less then current year");
                }
                _year = value;
            }
        }

        public Book(int id, string name, int price, string genre, string autor, int year) : base(id, name, price)
        {
            Genre = genre;
            Autor = autor;
            Year = year;
        }

        public override bool ContainsTerm(string term)
        {
            return Name.Contains(term)||Genre.Contains(term)|| Autor.Contains(term);
        }

        public override string ToString()
        {
            return String.Format(ID + '\n' + Name + '\n' + Price.ToString() + '\n' + Genre + '\n' + Autor + '\n' + Year.ToString());
        }
    }
}
