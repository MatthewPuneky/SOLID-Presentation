using System;

namespace InterfaceSegregationPrinciple.Example1.After.XeroxParts
{
    public interface ICoffeeMaker
    {
        void MakeCoffee();
    }

    public class CoffeeMaker : ICoffeeMaker
    {
        public void MakeCoffee()
        {
            Console.WriteLine("Made coffee for you");
        }
    }
}
