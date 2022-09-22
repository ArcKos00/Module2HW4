using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Weapons;
using SettingsFile;
using UnitControls;

namespace ObjectClassLibrary.Units
{
    public class Mage : MageStudent, IMove, IAttack, ICast
    {
        private WeapWizzardStaff _staff;
        private Skill[] _spells = new Skill[] { new FireBall(), new FrostBolt() };
        public Mage(string name, int health, int damage, int armor, WeapWizzardStaff staff)
            : base(name, health, damage, armor)
        {
            DamageType = TypeOfDamage.Phisical;
            Damage += staff.WDamage;
            _staff = staff;
        }

        public virtual void Cast()
        {
            Console.WriteLine($"{Name} исполнит заклинание: ");
            Console.WriteLine("1-FireBall, 2-FrostBolt");
            Unit target = UnitControl.GetInstance.Units[new Random().Next(0, Settings.CountEnemy)];
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    foreach (IMono spell in _spells)
                    {
                        if (spell is FireBall)
                        {
                            spell.Cast(target);
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    foreach (IMono spell in _spells)
                    {
                        if (spell is FrostBolt)
                        {
                            spell.Cast(target);
                        }
                    }

                    break;
            }
        }

        public override void Attack(Unit target)
        {
            int damage = Damage - (target.Armor * 4 / 5);
            target.CurrentHealth -= damage;
            Console.WriteLine($"{Name} тыкает палкой в {target.Name} и наносит урон {Damage}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Speed}");
        }
    }
}
