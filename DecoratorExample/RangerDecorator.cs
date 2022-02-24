using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public abstract class RangerDecorator : IPowerRanger
    {
        protected IPowerRanger _rangerDecorado;

        public RangerDecorator(IPowerRanger rangerDecorado)
        {
            _rangerDecorado = rangerDecorado;
        }
        
        public virtual void Transformacion(PowerRanger ranger)
        {
            _rangerDecorado.Transformacion(ranger);
        }
    }
}
