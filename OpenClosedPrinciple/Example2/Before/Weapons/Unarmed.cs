using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Example2.Before.Weapons
{
    public class Unarmed
    {
        public int Damage { get; } = 1;

        public int UnarmedAttack()
        {
            Console.WriteLine("You attack with your fists!");
            return Damage;
        }
    }
}
