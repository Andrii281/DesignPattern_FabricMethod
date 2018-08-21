using System;
using System.Collections.Generic;

namespace DesignPattern_FabricMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFruit> basket = new List<IFruit>();

            IShop shop = new Shop();

            var apple = shop.GetFruit(FruitName.Apple);
            var orange = shop.GetFruit(FruitName.Orange);
            var lemon = shop.GetFruit(FruitName.Lemon);

            basket.Add(apple);
            basket.Add(orange);
            basket.Add(lemon);

            Console.WriteLine("W koszyku znajdują się:");
            foreach (var fruit in basket)
            {
                Console.WriteLine(fruit.Name);
            }
        }
    }
}
