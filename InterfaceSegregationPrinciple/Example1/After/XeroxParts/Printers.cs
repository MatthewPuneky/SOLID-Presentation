using System;

namespace InterfaceSegregationPrinciple.Example1.After.XeroxParts
{
    public interface IPrinter
    {
        void Print();
    }

    public class V1Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printed a document using V1");
        }
    }

    public class V2Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printed a document using V2");
        }
    }
}
