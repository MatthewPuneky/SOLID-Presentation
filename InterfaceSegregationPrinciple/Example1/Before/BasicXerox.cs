using System;

namespace InterfaceSegregationPrinciple.Example1.Before
{
    public class BasicXeroxMacine : IXeroxMacine
    {
        public void Print()
        {
            Console.WriteLine("Printed a document");
        }

        public void Scan()
        {
            Console.WriteLine("Scanned a document");
        }

        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void ChangeToner()
        {
            Console.WriteLine("Toner changed");
        }

        public void MakeCoffee()
        {
            throw new NotImplementedException();
        }
    }
}
