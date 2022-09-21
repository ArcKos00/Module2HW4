using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Units
{
    public class Goblin : Unit, IMove, IAttack, ICast
    {
        private Skill[] _spells = new Skill[] { new Charge(20), new Heal() };
        public Goblin(int damage, string name, int health)
            : base(health)
        {
            Damage = damage;
            Name = name;
        }

        public void Cast()
        {
            Console.WriteLine($"Виберите спообность которую использует {Name}: ");
            Console.WriteLine("1-Heal, 2-Charge");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    foreach (IMore spell in _spells)
                    {
                        if (spell is Heal)
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
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {Damage}");
        }

        void IMove.Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Damage}");
        }
    }
}
