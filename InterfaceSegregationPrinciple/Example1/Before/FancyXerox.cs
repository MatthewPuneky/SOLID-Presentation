using System;

namespace InterfaceSegregationPrinciple.Example1.Before
{
    public class FancyXeroxMacine : IXeroxMacine
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
            Console.WriteLine("Faxed a document");
        }

        public void ChangeToner()
        {
            throw new NotImplementedException();
        }

        public void MakeCoffee()
        {
            Console.WriteLine("Made coffee for you");
        }
    }

    //public class FancyXeroxBlackFridayVersion : IFancyXerox
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("Printed a document using older version printer");
    //    }

    //    public void Scan()
    //    {
    //        Console.WriteLine("Scanned a document with slow scanner");
    //    }

    //    public void Fax()
    //    {
    //        Console.WriteLine("Faxed a document with low bitrate");
    //    }

    //    public void MakeCoffee()
    //    {
    //        Console.WriteLine("Made coffee for you");
    //    }
    //}
}
