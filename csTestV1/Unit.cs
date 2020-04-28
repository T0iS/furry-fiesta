using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csTestV1
{
    class Unit
    {
        private string name;
        private double price;

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
        }
        public Unit (string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
