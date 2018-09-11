using System;

namespace OpenClosedPrinciple.Example2.After.Weapons
{
    public class Axe : IWeaponStrategy
    {
        public int Damage { get; } = 4;

        public int Attack()
        {
            Console.WriteLine("You attacked with your Axe!");
            return Damage;
        }
    }
}
