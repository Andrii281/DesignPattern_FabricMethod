using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_FabricMethod
{
    public class Fruit : IFruit
    {
        public string Name { get; private set; }

        public Fruit(FruitName name)
        {
            Name = name.ToString();
        }
    }
}
