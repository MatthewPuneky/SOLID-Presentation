using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Example2.Before.Weapons
{
    public class Bow
    {
        public int Damage { get; } = 3;

        public int AxeAttack()
        {
            Console.WriteLine("You attacked with your Bow!");
            return Damage;
        }
    }
}
