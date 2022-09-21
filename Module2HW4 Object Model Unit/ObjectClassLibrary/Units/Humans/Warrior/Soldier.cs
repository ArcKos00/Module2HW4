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
        public Soldier(string name, int health, int damage, float speed, WeapSword sword)
            : base(name, health, damage)
        {
            Armor += 2;
            Speed *= speed;
            Damage += sword.WDamage;
            _sword = sword;
        }

        public WeapSword Sword
        {
            get { return _sword; }
        }

        void IAttack.Attack(Unit target)
        {
            target.CurrentHealth -= Damage;
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {Damage}");
        }

        void IMove.Move()
        {
            Console.WriteLine($"{Name} идёт со скоростью {Speed}");
        }
    }
}
