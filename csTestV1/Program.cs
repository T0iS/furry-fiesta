using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csTestV1
{
    class Program
    {
        static void Main(string[] args)
        {

            PowerPlant A = new PowerPlant("Temelin", new Unit("Unit A", 100));
            PowerPlant B = new PowerPlant("Dukovany", new Unit("Unit B", 22));

            House A1 = new House("A1", 123000);
            A1.PowerPlant = A;
            House A2 = new House("A2", 45600);
            A2.PowerPlant = A;
            House A3 = new House("A3", 78900);
            A3.PowerPlant = A;
            House B1 = new House("B1", 44200);
            B1.PowerPlant = B;
            House B2 = new House("B2", 22300);
            B2.PowerPlant = B;
            House B3 = new House("B3", 11100);
            B3.PowerPlant = B;



            List<House> lh = new List<House>
            {
                A1,A2,A3,
                B1,B2,B3
            };

            lh.Sort();
            foreach(House h in lh)
            {
                Console.WriteLine(h.ToString());

            }

            for( int i = 1; i<41; i++)
            {
                try
                {
                    A.Produce((uint)i);
                    B.Produce((uint)i);
                }
                catch( Exception e )
                {
                    Console.WriteLine(e);
                }
            }



            lh.Sort();
            using (StreamWriter writetext = new StreamWriter("export.txt"))
            {
                writetext.WriteLine(lh.Last().ToString());
            }
        }
    }
}
