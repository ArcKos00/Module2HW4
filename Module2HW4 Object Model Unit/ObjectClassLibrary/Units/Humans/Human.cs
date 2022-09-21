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

        public void Attack(Unit target)
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
