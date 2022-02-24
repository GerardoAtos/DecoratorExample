using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    internal class RangerAzul : IPowerRanger
    {
        public void Transformacion(PowerRanger ranger)
        {
            Console.WriteLine("Ranger Azul, TRANSFORMACIOOON!!!");
            Console.WriteLine(ranger.Name + " Se ha transformado");
        }
    }
}
