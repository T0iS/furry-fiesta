using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csTestV1
{
    interface IConsumer
    {
        double Balance { get; set; }
        List<uint> History { get; set; }
        string Name { get; set; }
        PowerPlant PowerPlant { get; set; }
    }
}
