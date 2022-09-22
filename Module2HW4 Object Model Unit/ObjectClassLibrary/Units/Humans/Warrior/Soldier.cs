using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Units
{
    public class Soldier : Human, IMove, IAttack
    {
        private WeapSword _sword;
        public Soldier(string name, int health, int damage, int armor, float speed, WeapSword sword)
            : base(name, health, damage)
        {
            Armor += armor;
            Speed *= speed;
            Damage += sword.WDamage;
            _sword = sword;
        }

        public WeapSword Sword
        {
            get { return _sword; }
        }

        public override void Attack(Unit target)
        {
            int damage = Damage - (target.Armor * 4 / 5);
            target.CurrentHealth -= damage;
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {Damage}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идёт со скоростью {Speed}");
        }
    }
}
