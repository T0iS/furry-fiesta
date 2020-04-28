using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csTestV1
{
    class House: IComparable<House>, IConsumer
    {
        private PowerPlant _powerPlant;

        private double _balance;
        private List<uint> _history= new List<uint>();
        private string _name;

        public House(string name, double balance)
        {
            this.Balance = balance;
            this.Name = name;
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                this._balance = value;
            }
        }
        public List<uint> History
        {
            get
            {
                return this._history;
            }
            set
            {
                this._history = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public PowerPlant PowerPlant
        {
            get
            {
                return this._powerPlant;
            }
            set
            {
                if (Balance >= value.Unit.Price)
                {
                    this._powerPlant = value;
                   
                    value.OnEnergyProduced += this.ConsumeEnergy;
                }
            }
        }

        public int CompareTo(House other)
        {
            return (int)(this.Balance - other.Balance);
        }

       


        public void ConsumeEnergy(uint amount)
        {
            if(Balance < PowerPlant.Unit.Price * amount)
            {
                PowerPlant.OnEnergyProduced -= this.ConsumeEnergy;
                throw new Exception("Nedostatek prostredku na zaplaceni, dum nemuze odebirat elektrinu");

            }
            Balance -= PowerPlant.Unit.Price * amount;
            Console.WriteLine("Spotrebovano: " + amount);
            this.History.Add(amount);
        }

        override public string ToString()
        {
            return Name + " B: " + Balance;
        }



        
    }
}
