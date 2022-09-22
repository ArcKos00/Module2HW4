using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Interfaces;
using UnitControls;
using SettingsFile;

namespace ObjectClassLibrary.Units
{
    public class Goblin : Unit, IMove, IAttack, ICast
    {
        private Skill[] _spells = new Skill[] { new Charge(20), new Heal() };
        public Goblin(int damage, string name, int health)
            : base(health)
        {
            UGenus = Genus.Goblin;
            Damage = damage;
            Name = name;
        }

        public void Cast()
        {
            Console.WriteLine($"Виберите спообность которую использует {Name}: ");
            Console.WriteLine("1-Heal, 2-Charge");
            Unit[] units = UnitControl.GetInstance.Units;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    foreach (IMore spell in _spells)
                    {
                        if (spell is Heal)
                        {
                            Unit[] unitsToSkill = new Unit[4];
                            for (int i = 0; i < unitsToSkill.Length; i++)
                            {
                                unitsToSkill[i] = units[new Random().Next(0, Settings.CountEnemy)];
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
                            Unit target = units[new Random().Next(Settings.CountEnemy, units.Length)];
                            spell.Cast(target);
                        }
                    }

                    break;
            }
        }

        public void Attack(Unit target)
        {
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {Damage}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Damage}");
        }
    }
}
