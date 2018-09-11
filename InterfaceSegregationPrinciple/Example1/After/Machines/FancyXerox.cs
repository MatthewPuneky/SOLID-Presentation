using InterfaceSegregationPrinciple.Example1.After.XeroxParts;

namespace InterfaceSegregationPrinciple.Example1.After.Machines
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
