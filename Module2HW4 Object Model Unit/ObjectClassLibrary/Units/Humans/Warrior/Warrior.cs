using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SettingsFile;
using UnitControls;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Units
{
    public class Warrior : Soldier, IMove, IAttack, ICast
    {
        private readonly Charge _spell = new Charge();
        public Warrior(string name, int health, int damage, int armor, float speed, WeapSword sword)
            : base(name, health, damage, armor, speed, sword)
        {
        }

        public virtual void Cast()
        {
            Unit target = UnitControl.GetInstance.Units[new Random().Next(0, Settings.CountEnemy)];
            _spell.Cast(target);
        }

        public override void Attack(Unit target)
        {
            int damage = Damage - (target.Armor * 4 / 5);
            target.CurrentHealth -= damage;
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {Damage}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Speed}");
        }
    }
}
