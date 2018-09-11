using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Example2.Before.Weapons
{
    public class Axe
    {
        public int Damage { get; } = 4;

        public int AxeAttack()
        {
            Console.WriteLine("You attacked with your Axe!");
            return Damage;
        }
    }
}
