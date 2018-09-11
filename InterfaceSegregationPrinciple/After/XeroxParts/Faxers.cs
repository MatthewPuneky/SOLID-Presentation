using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.After.XeroxParts
{
    public interface IFaxer
    {
        void Fax();
    }

    public class SlowFaxer : IFaxer
    {
        public void Fax()
        {
            Console.WriteLine("Faxed a document using the slow faxer");
        }
    }

    public class FastFaxer : IFaxer
    {
        public void Fax()
        {
            Console.WriteLine("Faxed a document using the fast faxer");
        }
    }
}
