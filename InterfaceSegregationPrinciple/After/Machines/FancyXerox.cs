using System;
using System.Collections.Generic;
using System.Text;
using InterfaceSegregationPrinciple.After.XeroxParts;

namespace InterfaceSegregationPrinciple.After.Machines
{
    public class FancyXerox 
    {
        public IPrinter Printer;
        public IScanner Scanner;
        public IFaxer Faxer;
        public ICoffeeMaker CoffeeMaker;

        public FancyXerox(
            IPrinter printer,
            IScanner scanner,
            IFaxer faxer,
            ICoffeeMaker coffeeMaker)
        {
            Printer = printer;
            Scanner = scanner;
            Faxer = faxer;
            CoffeeMaker = coffeeMaker;
        }
    }
}
