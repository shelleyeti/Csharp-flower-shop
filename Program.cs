using System;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerShop myShop = new FlowerShop();

            foreach (var flower in myShop.BirthdayArrangement)
            {
                Console.WriteLine($"Color is the only accessible property because of the interface List<Type> {flower.Color}");
            }
        }
    }
}
