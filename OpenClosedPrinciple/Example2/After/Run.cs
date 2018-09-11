using System;
using OpenClosedPrinciple.Example2.After.Weapons;

namespace OpenClosedPrinciple.Example2.After
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

            //player.CurrentWeapon = 32;
            //player.AttackWithWeapon();
        }
    }

    public class Player
    {
        public IWeaponStrategy CurrentWeapon { get; set; } = new Unarmed();

        public void AttackWithWeapon()
        {
            var damage = CurrentWeapon.Attack();
            Console.WriteLine($"Caused {damage} points of damage");
        }
    }
}
