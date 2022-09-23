using UnitControls;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Units.Enums;

namespace ObjectClassLibrary.Units
{
    public class Warrior : Soldier, IMove, IAttack, ICast
    {
        private readonly Charge _spell = new Charge();
        public Warrior(string name, int health, int damage, int armor, float speed, WeapSword sword, UnitsType type)
            : base(name, health, damage, armor, speed, sword, type)
        {
        }

        public virtual void Cast()
        {
            Unit[] unit = UnitControl.GetInstance.Units;
            int rand = 0;
            while (true)
            {
                rand = new Random().Next(0, Settings.CountEnemy);
                if (unit[rand] != null)
                {
                    break;
                }
            }

            _spell.Cast(unit[rand]);
        }

        public override void Attack(Unit target)
        {
            int damage = Damage - (target.Armor * 4 / 5);
            target.CurrentHealth -= damage;
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {damage}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Speed}");
        }
    }
}
