using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.After.XeroxParts
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
