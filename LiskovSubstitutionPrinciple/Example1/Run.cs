using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.Example1
{
    public class Run
    {
        public static void Operation()
        {
            Rectangle shape1 = new Rectangle();
            shape1.SetHeight(10);
            shape1.SetWidth(12);
            Console.WriteLine($"Area of a Rectangle is: {shape1.GetArea}");

            Rectangle shape2 = new Square();
            shape2.SetHeight(12);
            shape2.SetWidth(10);
            Console.WriteLine($"Area of a Rectangle is: {shape2.GetArea}");
        }
    }
}
