using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csTestV1
{
    class PowerPlant
    {
        private string name;
        private Unit unit;

        
        public delegate void EnergyProduceDelegate(uint amount);

        public event EnergyProduceDelegate OnEnergyProduced;


        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public Unit Unit
        {
            get
            {
                return this.unit;
            }
        }


        public PowerPlant(string name, Unit unit)
        {
            this.name = name;
            this.unit = unit;
        }

        public void Produce(uint amount)
        {
            OnEnergyProduced?.Invoke(amount);
            Console.WriteLine("......Start produkce......");
        }

    }
}
