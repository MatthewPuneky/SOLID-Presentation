using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.After.XeroxParts
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
