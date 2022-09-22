using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Units
{
    public class Human : Unit, IMove, IAttack
    {
        public Human(string name, int health, int damage)
            : base(health)
        {
            DamageType = Weapons.TypeOfDamage.Phisical;
            Damage = damage;
            UGenus = Genus.Human;
            Name = name;
        }

        public virtual void Attack(Unit target)
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
