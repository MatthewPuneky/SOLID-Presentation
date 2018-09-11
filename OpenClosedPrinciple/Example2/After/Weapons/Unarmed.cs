﻿using System;

namespace OpenClosedPrinciple.Example2.After.Weapons
{
    public class Unarmed : IWeaponStrategy
    {
        public int Damage { get; } = 1;

        public int Attack()
        {
            Console.WriteLine("You attack with your fists!");
            return Damage;
        }
    }
}
