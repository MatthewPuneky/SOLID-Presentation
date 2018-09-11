using InterfaceSegregationPrinciple.Example1.After.XeroxParts;

namespace InterfaceSegregationPrinciple.Example1.After.Machines
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
