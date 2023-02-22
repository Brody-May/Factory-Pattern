using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public void Build()
        {
            Console.WriteLine("The Car is being put together");
            Console.WriteLine("This could take a while....");
        }
    }


}
