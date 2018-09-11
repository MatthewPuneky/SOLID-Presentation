using System;
using System.Collections.Generic;
using System.Text;
using InterfaceSegregationPrinciple.After.XeroxParts;

namespace InterfaceSegregationPrinciple.After.Machines
{
    public class XeroxCoffeePotExpress
    {
        public IPrinter Printer { get; }
        public ICoffeeMaker CoffeeMaker { get; }

        public XeroxCoffeePotExpress(
            IPrinter printer,
            ICoffeeMaker coffeeMaker)
        {
            Printer = printer;
            CoffeeMaker = coffeeMaker;
        }
    }
}
