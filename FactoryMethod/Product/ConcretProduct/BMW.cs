using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product.ConcretProduct
{
   public  class BMW : ICar
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public BMW(string _color , string _model)
        {
            Type = "BMW";
            Color = _color;
            Model = _model;
        }

        
    }
}
