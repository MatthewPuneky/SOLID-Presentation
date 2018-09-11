using InterfaceSegregationPrinciple.Example1.After.XeroxParts;

namespace InterfaceSegregationPrinciple.Example1.After.Machines
{
    public class BasicXerox
    {
        public IPrinter Printer { get; }
        public IScanner Scanner { get; }
        public IToner Toner { get; }

        public BasicXerox(
            IPrinter printer,
            IScanner scanner,
            IToner toner)
        {
            Printer = printer;
            Scanner = scanner;
            Toner = toner;
        }
    }
}
