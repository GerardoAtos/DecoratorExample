using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class PowerRanger
    {

        public PowerRanger(int Id, string Name, string Generacion)
        {
            this.Id = Id;
            this.Name = Name;
            this.Generacion = Generacion;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Generacion { get; set; }
    }
}
