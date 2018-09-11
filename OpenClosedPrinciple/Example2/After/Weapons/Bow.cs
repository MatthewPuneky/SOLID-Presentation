using System;

namespace OpenClosedPrinciple.Example2.After.Weapons
{
    public class Bow : IWeaponStrategy
    {
        public int Damage { get; } = 3;

        public int Attack()
        {
            Console.WriteLine("You attacked with your Bow!");
            return Damage;
        }
    }
}
