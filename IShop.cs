using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_FabricMethod
{
    public interface IShop
    {
        IFruit GetFruit(FruitName name);
    }
}
