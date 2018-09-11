using System;
using System.Collections.Generic;
using System.Text;
using OpenClosedPrinciple.Example2.Before.Weapons;

namespace OpenClosedPrinciple.Example2.Before
{
    public class Run
    {
        public static void Operation()
        {
            var player = new Player();
            player.AttackWithWeapon();

            player.CurrentWeapon = new Sword();
            player.AttackWithWeapon();

            player.CurrentWeapon = new Bow();
            player.AttackWithWeapon();

            player.CurrentWeapon = 32;
            player.AttackWithWeapon();
        }
    }

    public class Player
    {
        public object CurrentWeapon = new Unarmed();

        public void AttackWithWeapon()
        {
            if (CurrentWeapon is Axe axe)
            {
                var damage = axe.AxeAttack();
                Console.WriteLine($"Caused {damage} points of damage");
            }
            else if (CurrentWeapon is Sword sword)
            {
                var damage = sword.SwordAttack();
                Console.WriteLine($"Caused {damage} points of damage");
            }
            else if (CurrentWeapon is Unarmed unarmed)
            {
                var damage = unarmed.UnarmedAttack();
                Console.WriteLine($"Caused {damage} points of damage");
            }
            else
            {
                throw new Exception("Unknown weapon type.");
            }
        }
    }
}
