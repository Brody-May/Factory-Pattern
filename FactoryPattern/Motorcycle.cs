using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicle
    {
        public void Build()
        {
            Console.WriteLine("The Motorcycle is being built.");
            Console.WriteLine("Clink Clank");
        }
    }
}
