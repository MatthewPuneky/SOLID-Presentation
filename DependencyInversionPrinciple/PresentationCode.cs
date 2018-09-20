using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    //// The old junky model. Only non-Fortune 500 companies have this.
    //public class BasicCoffeeMachine
    //{
    //    public void BrewCoffee()
    //    {
    //        // var coffeeGrounds = GetBag(BasicBrands.Community).ScoopGrounds();
    //        // return pot.Brew(coffeeGrounds);
    //    }
    //}

    //// The latest and greatest! Comes with a monthly subscription to fancy magazine!
    //public class FancyCoffeeMachine
    //{
    //    public void BrewCoffeeButFancily()
    //    {
    //        // var coffeeBeans = TravelToChile().PickCoffeeBeans(100);
    //        // var coffeeGrounds = _grinder.Grind(coffeeBeans).GetGrounds();
    //        // return pot.Brew(coffeeGrounds);
    //    }
    //}

    //public class BreakRoom
    //{
    //    // New company - it's the best they could afford
    //    public BasicCoffeeMachine CoffeeMachine => new BasicCoffeeMachine();

    //    public void MakeAPotOfCoffee()
    //    {
    //        CoffeeMachine.BrewCoffee();
    //    }
    //}

    //public class BreakRoom
    //{
    //    // The company wants to look wealthy, but now they need to edit and 
    //    //   recompile the whole breakroom to use this - not to mention
    //    //   retest it. (who would have thought I'd bring up testing)
    //    public FancyCoffeeMachine CoffeeMachine => new FancyCoffeeMachine();

    //    public void MakeAPotOfCoffee()
    //    {
    //        CoffeeMachine.BrewCoffeeButFancily();
    //    }
    //}

    //// The world's greatest invention - the interface! 
    //public interface ICoffeeMachine
    //{
    //    void BrewCoffee();
    //}

    //// We set the basic coffee machine to depend on the interface, enforcing the
    ////   fact that BrewCoffee() exists.
    //public class BasicCoffeeMachine : ICoffeeMachine
    //{
    //    public void BrewCoffee()
    //    {
    //        // var coffeeGrounds = GetBag(BasicBrands.Community).ScoopGrounds();
    //        // return pot.Brew(coffeeGrounds);
    //    }
    //}

    //// The fancy coffee machine also uses this interface, since it can brew coffee.
    ////   Notice that we had to change the name to BrewCoffee, since it must obey
    ////   the contract of the interface.
    //public class FancyCoffeeMachine : ICoffeeMachine
    //{
    //    public void BrewCoffee()
    //    {
    //        // var coffeeBeans = TravelToChile().PickCoffeeBeans(100);
    //        // var coffeeGrounds = _grinder.Grind(coffeeBeans).GetGrounds();
    //        // return pot.Brew(coffeeGrounds);
    //    }
    //}

    //public class BreakRoom
    //{
    //    // Now that we have a common interface, we can make our variable 
    //    //   polymorphically be either a basic or fancy coffee machine.
    //    //   The only issue is if we want to change the machine, we must
    //    //   still edit and recompile this class. Not what we want.
    //    public ICoffeeMachine CoffeeMachine => new FancyCoffeeMachine();

    //    public void MakeAPotOfCoffee()
    //    {
    //        CoffeeMachine.BrewCoffee();
    //    }
    //}

    //public static class MachineFactory
    //{
    //    public static ICoffeeMachine ProduceBreakRoomCoffeeMachine() => new BasicCoffeeMachine();
    //}

    //public class BreakRoom
    //{
    //    // This is getting better. Now, if we want to change which coffee machine 
    //    //   gets created, we just need to update our factory. Just what it was 
    //    //   made for! This can be a little better though.
    //    public ICoffeeMachine CoffeeMachine => MachineFactory.ProduceBreakRoomCoffeeMachine();

    //    public void MakeAPotOfCoffee()
    //    {
    //        CoffeeMachine.BrewCoffee();
    //    }
    //}

    //public class BreakRoom
    //{
    //    // Now this is the best it can be. This class doesn't even manage which factory
    //    //   creates the coffee machine. We don't care how it gets created, we only
    //    //   care that it exists. In this case, we would normally use dependency 
    //    //   injection to decide which machine will be sent in. Our class is no longer
    //    //   dependant on the detail - only referencing the abstraction.
    //    private readonly ICoffeeMachine _coffeeMachine;

    //    public BreakRoom(ICoffeeMachine coffeeMachine)
    //    {
    //        _coffeeMachine = coffeeMachine;
    //    }

    //    public void MakeAPotOfCoffee()
    //    {
    //        _coffeeMachine.BrewCoffee();
    //    }
    //}
}
