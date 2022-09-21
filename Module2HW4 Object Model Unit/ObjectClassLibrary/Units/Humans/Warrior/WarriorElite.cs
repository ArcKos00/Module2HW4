using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Units
{
    public sealed class WarriorElite : Warrior, IMove, IAttack, ICast
    {
        private Skill[] _spells = new Skill[] { new Charge(), new AddPower() };
        public WarriorElite(string name, int health, int damage, float speed, WeapSword sword)
            : base(name, health, damage, speed, sword)
        {
            Armor += 2;
        }

        public void Cast()
        {
            Console.WriteLine($"{Name} исполнит заклинание: ");
            Console.WriteLine("1-AddPower, 2-Charge");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    foreach (IMore spell in _spells)
                    {
                        if (spell is AddPower)
                        {
                            spell.Cast();
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    foreach (IMono spell in _spells)
                    {
                        if (spell is Charge)
                        {
                            spell.Cast();
                        }
                    }

                    break;
            }
        }

        void IAttack.Attack(Unit target)
        {
            target.CurrentHealth -= Damage;
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {Damage}");
        }

        void IMove.Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Speed}");
        }
    }
}
