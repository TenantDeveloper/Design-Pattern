using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product.ConcretProduct
{
   public class Audi : ICar
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public Audi(string _color , string _model)
        {
            Type = "AUDI";
            Color = _color;
            Model = _model;
        }
    }
}
