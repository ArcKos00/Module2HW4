using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Units
{
    public class Mage : MageStudent, IMove, IAttack, ICast
    {
        private WeapWizzardStaff _staff;
        private Skill[] _spells = new Skill[] { new FireBall(), new FrostBolt() };
        public Mage(string name, int health, int damage, WeapWizzardStaff staff)
            : base(name, health, damage)
        {
            DamageType = TypeOfDamage.Phisical;
            Armor += 1;
            Damage += staff.WDamage;
            _staff = staff;
        }

        public void Cast()
        {
            Console.WriteLine($"{Name} исполнит заклинание: ");
            Console.WriteLine("1-FireBall, 2-FrostBolt");
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
