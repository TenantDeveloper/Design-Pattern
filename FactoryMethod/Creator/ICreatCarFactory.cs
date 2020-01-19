using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
   public interface ICreatCarFactory
    {
        ICar GetCar(); 
    }
}
