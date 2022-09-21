using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Units
{
    public class Warrior : Soldier, IMove, IAttack, IMono
    {
        private readonly Charge _spell = new Charge();
        public Warrior(string name, int health, int damage, float speed, WeapSword sword)
            : base(name, health, damage, speed, sword)
        {
            Armor += 2;
        }

        public void Cast(Unit target)
        {
            _spell.Cast(target);
        }

        void IAttack.Attack(Unit target)
        {
            target.CurrentHealth -= Damage;
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {Damage}");
        }

        void IMove.Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Speed}");
        }
    }
}
