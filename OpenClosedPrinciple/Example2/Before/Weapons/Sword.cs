using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Example2.Before.Weapons
{
    public class Sword
    {
        public int Damage { get; } = 3;

        public int SwordAttack()
        {
            Console.WriteLine("You attacke with your Sword!");
            return Damage;
        }
    }
}
