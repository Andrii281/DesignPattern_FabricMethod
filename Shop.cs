using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_FabricMethod
{
    public class Shop : IShop
    {
        public IFruit GetFruit(FruitName name)
        {
            return new Fruit(name);
        }
    }
}
