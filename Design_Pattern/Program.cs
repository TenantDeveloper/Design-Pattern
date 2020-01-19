using FactoryMethod.Creator;
using FactoryMethod.Creator.ConcretCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factor Method Implementation;
            var factory = new CreateCarFactory("BMW", "Black", "2012") as ICreatCarFactory;
             var myCar =  factory.GetCar();
            Console.WriteLine($"type is {myCar.Type}");
            Console.ReadKey();
        }
    }
}
