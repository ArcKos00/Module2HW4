using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Weapons;
using SettingsFile;
using UnitControls;

namespace ObjectClassLibrary.Units
{
    public sealed class WarriorElite : Warrior, IMove, IAttack, ICast
    {
        private Skill[] _spells = new Skill[] { new Charge(), new AddPower() };
        public WarriorElite(string name, int health, int damage, int armor, float speed, WeapSword sword)
            : base(name, health, damage, armor, speed, sword)
        {
        }

        public override void Cast()
        {
            Console.WriteLine($"{Name} исполнит заклинание: ");
            Console.WriteLine("1-AddPower, 2-Charge");
            Unit[] units = UnitControl.GetInstance.Units;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    foreach (IMore spell in _spells)
                    {
                        if (spell is AddPower)
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
                case ConsoleKey.D2:
                    foreach (IMono spell in _spells)
                    {
                        if (spell is Charge)
                        {
                            spell.Cast(units[new Random().Next(0, Settings.CountEnemy)]);
                        }
                    }

                    break;
            }
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
