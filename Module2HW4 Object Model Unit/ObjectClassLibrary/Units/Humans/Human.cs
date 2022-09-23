using ObjectClassLibrary;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Units.Enums;

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
            if (damage < 0)
            {
                damage = 0;
            }

            target.CurrentHealth -= damage;
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {damage}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идёт со скоростью {Speed}");
        }
    }
}
