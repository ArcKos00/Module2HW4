using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;
using SettingsFile;
using UnitControls;

namespace ObjectClassLibrary.Units
{
    public sealed class UpperMage : Mage, IMove, IAttack, ICast
    {
        private Skill[] _spells = new Skill[] { new FireBall(), new FrostBolt(), new Heal() };
        public UpperMage(string name, int health, int damage, int armor, WeapWizzardStaff staff)
            : base(name, health, damage, armor, staff)
        {
        }

        public override void Cast()
        {
            Console.WriteLine($"{Name} исполнит заклинание: ");
            Console.WriteLine("1-FireBall, 2-FrostBolt, 3-Heal");
            Unit[] units = UnitControl.GetInstance.Units;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    foreach (IMono spell in _spells)
                    {
                        if (spell is FireBall)
                        {
                            Unit target = units[new Random().Next(0, Settings.CountEnemy)];
                            spell.Cast(target);
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    foreach (IMono spell in _spells)
                    {
                        if (spell is FrostBolt)
                        {
                            Unit target = units[new Random().Next(0, Settings.CountEnemy)];
                            spell.Cast(target);
                        }
                    }

                    break;
                case ConsoleKey.D3:
                    foreach (IMore spell in _spells)
                    {
                        if (spell is Heal)
                        {
                            Unit[] unitsToSkill = new Unit[4];
                            for (int i = 0; i < unitsToSkill.Length; i++)
                            {
                                unitsToSkill[i] = units[new Random().Next(Settings.CountEnemy, units.Length)];
                            }

                            spell.Cast(unitsToSkill);
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
