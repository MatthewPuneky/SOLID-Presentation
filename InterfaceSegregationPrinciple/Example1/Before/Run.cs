namespace InterfaceSegregationPrinciple.Example1.Before
{
    public class Run
    {
        public static void Operation()
        {
            var basicXerox = new BasicXeroxMacine();
            basicXerox.Scan();
            basicXerox.Print();
            basicXerox.ChangeToner();
            
            var fancyXerox = new FancyXeroxMacine();
            fancyXerox.Scan();
            fancyXerox.MakeCoffee();
            fancyXerox.Fax();
        }
    }
}
