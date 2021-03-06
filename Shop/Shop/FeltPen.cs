﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class FeltPen: Product
    {
        private int _countOfPens;
        public FeltPen(int id, string name, int price, int countOfPens) : base(id, name, price)
        {
            CountOfPens = countOfPens;
        }

        public int CountOfPens
        {
            get { return _countOfPens; }
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
                _countOfPens = value;
            }
        }

        public override bool ContainsTerm(string term)
        {
            return Name.Contains(term);
        }

        public override string ToString()
        {
            return String.Format(ID + '\n' + Name + '\n' + Price.ToString() + '\n' + CountOfPens.ToString());
        }
    }
}
