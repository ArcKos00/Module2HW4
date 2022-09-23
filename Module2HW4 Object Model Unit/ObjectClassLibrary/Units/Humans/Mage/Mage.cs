using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Weapons;
using UnitControls;
using ObjectClassLibrary.Units.Enums;

namespace ObjectClassLibrary.Units
{
    public class Mage : MageStudent, IMove, IAttack, ICast
    {
        private WeapWizzardStaff _staff;
        private Skill[] _spells = new Skill[] { new FireBall(10), new FrostBolt(10) };
        public Mage(string name, int health, int damage, int armor, WeapWizzardStaff staff, UnitsType type)
            : base(name, health, damage, armor, type)
        {
            DamageType = TypeOfDamage.Phisical;
            Damage += staff.WDamage;
            _staff = staff;
        }

        public virtual void Cast()
        {
            Console.WriteLine($"{Name} исполнит заклинание: ");
            Console.WriteLine("1-FireBall, 2-FrostBolt");
            Unit[] units = UnitControl.GetInstance.Units;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    for (int i = 0; i < _spells.Length; i++)
                    {
                        if (_spells[i] is IMono && _spells[i] is FireBall)
                        {
                            int rand = 0;
                            while (true)
                            {
                                rand = new Random().Next(0, Settings.CountEnemy);
                                if (units[rand] != null)
                                {
                                    break;
                                }
                            }

                            Unit target = units[rand];
                            (_spells[i] as IMono).Cast(target);
                            break;
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    for (int i = 0; i < _spells.Length; i++)
                    {
                        if (_spells[i] is IMono && _spells[i] is FrostBolt)
                        {
                            int rand = 0;
                            while (true)
                            {
                                rand = new Random().Next(0, Settings.CountEnemy);
                                if (units[rand] != null)
                                {
                                    break;
                                }
                            }

                            Unit target = units[rand];
                            (_spells[i] as IMono).Cast(target);
                            break;
                        }
                    }

                    break;
            }
        }

        public override void Attack(Unit target)
        {
            int damage = Damage - (target.Armor * 4 / 5);
            target.CurrentHealth -= damage;
            if (damage < 0)
            {
                damage = 0;
            }

            Console.WriteLine($"{Name} тыкает палкой в {target.Name} и наносит урон {damage}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Speed}");
        }
    }
}
