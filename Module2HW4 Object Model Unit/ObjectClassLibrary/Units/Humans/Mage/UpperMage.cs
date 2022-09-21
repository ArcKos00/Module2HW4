using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Units
{
    public sealed class UpperMage : Mage, IMove, IAttack, ICast
    {
        private Skill[] _spells = new Skill[] { new FireBall(), new FrostBolt(), new Heal() };
        public UpperMage(string name, int health, int damage, WeapWizzardStaff staff)
            : base(name, health, damage, staff)
        {
            Armor += 1;
        }

        void ICast.Cast()
        {
            Console.WriteLine($"{Name} исполнит заклинание: ");
            Console.WriteLine("1-FireBall, 2-FrostBolt, 3-Heal");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    foreach (IMore spell in _spells)
                    {
                        if (spell is FireBall)
                        {
                            spell.Cast();
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    foreach (IMono spell in _spells)
                    {
                        if (spell is FrostBolt)
                        {
                            spell.Cast();
                        }
                    }

                    break;
                case ConsoleKey.D3:
                    foreach (IMore spell in _spells)
                    {
                        if (spell is Heal)
                        {
                            spell.Cast();
                        }
                    }

                    break;
            }
        }

        void IAttack.Attack(Unit target)
        {
            Console.WriteLine($"{Name} тыкает палкой в {target.Name} и наносит урон {Damage}");
        }

        void IMove.Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Speed}");
        }
    }
}
