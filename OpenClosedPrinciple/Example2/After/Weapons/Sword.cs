using System;

namespace OpenClosedPrinciple.Example2.After.Weapons
{
    public class Sword : IWeaponStrategy
    {
        public int Damage { get; } = 3;

        public int Attack()
        {
            Console.WriteLine("You attacke with your Sword!");
            return Damage;
        }
    }
}
