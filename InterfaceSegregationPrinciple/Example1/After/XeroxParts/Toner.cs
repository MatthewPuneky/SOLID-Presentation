using System;

namespace InterfaceSegregationPrinciple.Example1.After.XeroxParts
{
    public interface IToner
    {
        void ChangeToner();
    }

    public class Toner : IToner
    {
        public void ChangeToner()
        {
            Console.WriteLine("Toner changed");
        }
    }
}
