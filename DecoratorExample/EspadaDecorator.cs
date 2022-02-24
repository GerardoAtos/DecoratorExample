using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class EspadaDecorator : RangerDecorator
    {
        public EspadaDecorator(IPowerRanger rangerDecorado) : base(rangerDecorado)
        {

        }

        public override void Transformacion(PowerRanger ranger)
        {
            _rangerDecorado.Transformacion(ranger);
            agregarEspada(ranger);
        }

        public void agregarEspada(PowerRanger ranger)
        {
            Console.WriteLine("se agrego la espada al ranger: " + ranger.Name + "de la generacion: " );
        }
    }
}
