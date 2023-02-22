using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ThreeWheeler : IVehicle
    {
        public void Build()
        {
            Console.WriteLine("Your three wheeler is coming along");
        }
    }
}
