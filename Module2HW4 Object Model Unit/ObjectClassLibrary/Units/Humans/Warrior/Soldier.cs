using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Units.Enums;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Units
{
    public class Soldier : Human, IMove, IAttack
    {
        private WeapSword _sword;
        public Soldier(string name, int health, int damage, int armor, float speed, WeapSword sword, UnitsType type)
            : base(name, health, damage, type)
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
            if (damage < 0)
            {
                damage = 0;
            }

            Console.WriteLine($"{Name} атакует {target.Name} с уроном {damage}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идёт со скоростью {Speed}");
        }
    }
}
