using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    internal class RangerRojo : IPowerRanger
    {
        public void Transformacion(PowerRanger ranger)
        {
            Console.WriteLine("Ranger rojo, TRANSFORMACIOOON!!!");
            Console.WriteLine(ranger.Name + " Se ha transformado");
        }
    }
}
