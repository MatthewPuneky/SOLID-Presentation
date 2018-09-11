using System;

namespace InterfaceSegregationPrinciple.After.XeroxParts
{
    public interface IScanner
    {
        void Scan();
    }

    public class Scanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scanned a document");
        }
    }

    public class UltraScanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scanned a document using the ULTRA scanner!");
        }
    }
}
