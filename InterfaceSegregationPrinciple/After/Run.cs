using System;
using System.Collections.Generic;
using System.Text;
using InterfaceSegregationPrinciple.After.Machines;
using InterfaceSegregationPrinciple.After.XeroxParts;

namespace InterfaceSegregationPrinciple.After
{
    public class Run
    {
        public static void Operation()
        {
            var basicXerox = new BasicXerox(
                new V1Printer(), 
                new Scanner(), 
                new Toner());

            basicXerox.Scanner.Scan();
            basicXerox.Printer.Print();
            basicXerox.Toner.ChangeToner();

            var basicXeroxWithUpgrades = new BasicXerox(
                new V2Printer(), 
                new UltraScanner(), 
                new Toner());

            basicXeroxWithUpgrades.Scanner.Scan();
            basicXeroxWithUpgrades.Printer.Print();
            basicXeroxWithUpgrades.Toner.ChangeToner();

            var fancyXerox = new FancyXerox(
                new V2Printer(), 
                new UltraScanner(), 
                new FastFaxer(), 
                new CoffeeMaker());

            fancyXerox.Scanner.Scan();
            fancyXerox.CoffeeMaker.MakeCoffee();
            fancyXerox.Faxer.Fax();

            var fancyXeroxBlackFridayVerson = new FancyXerox(
                new V1Printer(),
                new Scanner(),
                new SlowFaxer(),
                new CoffeeMaker()
            );

            fancyXeroxBlackFridayVerson.Scanner.Scan();
            fancyXeroxBlackFridayVerson.CoffeeMaker.MakeCoffee();
            fancyXeroxBlackFridayVerson.Faxer.Fax();
        }
    }
}
