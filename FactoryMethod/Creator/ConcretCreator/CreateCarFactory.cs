using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Product;
using FactoryMethod.Product.ConcretProduct;

namespace FactoryMethod.Creator.ConcretCreator
{
    public class CreateCarFactory : ICreatCarFactory
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public CreateCarFactory(string _type , string _color , string _model)
        {
            Type = _type;
            Color = _color;
            Model = _model;
        }
       
        public ICar GetCar()
        {
            switch (Type)
            {
                case "BMW":
                case "bmw":
                    return new BMW(Color, Model);
                case "AUDI":
                case "audi":
                    return new Audi(Color, Model);
                default:
                    throw new ArgumentException("Invalid Type");
            }
        }
    }
}
