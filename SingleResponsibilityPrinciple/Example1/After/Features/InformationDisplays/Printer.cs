using System;

namespace SingleResponsibilityPrinciple.Example1.After.Features.InformationDisplays
{
    public static class Printer
    {
        public static void PrintLine(string message)
        {
            Console.WriteLine(message);
        }

        public static void Print(string message)
        {
            Console.Write(message);
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
