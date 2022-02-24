using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class PoderDecorator : RangerDecorator
    {
        public PoderDecorator(IPowerRanger rangerDecorado) : base(rangerDecorado)
        {

        }

        public override void Transformacion(PowerRanger ranger)
        {
            _rangerDecorado.Transformacion(ranger);
            agregarPoder(ranger);
        }

        public void agregarPoder(PowerRanger ranger)
        {
            Console.WriteLine("se agrego poder al ranger: " + ranger.Name);
        }





    }
}
