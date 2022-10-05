using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;
using UnitControls;
using ObjectClassLibrary.Units.Enums;

namespace ObjectClassLibrary.Units
{
    public sealed class UpperMage : Mage, IMove, IAttack, ICast
    {
        private Skill[] _spells = new Skill[] { new FireBall(), new FrostBolt(15), new Heal(20) };
        public UpperMage(string name, int health, int damage, int armor, WeapWizzardStaff staff, UnitsType type)
            : base(name, health, damage, armor, staff, type)
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
                    for (int i = 0; i < _spells.Length; i++)
                    {
                        if (_spells[i] is IMono && _spells[i] is FireBall)
                        {
                            int rand = 0;
                            while (true)
                            {
                                rand = new Random().Next(Settings.CountEnemy, units.Length);
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
                                rand = new Random().Next(Settings.CountEnemy, units.Length);
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
                case ConsoleKey.D3:
                    for (int i = 0; i < _spells.Length; i++)
                    {
                        if (_spells[i] is IMore && _spells[i] is Heal)
                        {
                            Unit[] unitsToSkill = new Unit[4];
                            for (int j = 0; j < unitsToSkill.Length; j++)
                            {
                                int rand = 0;
                                while (true)
                                {
                                    rand = new Random().Next(Settings.CountEnemy, units.Length);
                                    if (units[rand] != null)
                                    {
                                        break;
                                    }
                                }

                                unitsToSkill[j] = units[rand];
                            }

                            (_spells[i] as IMore).Cast(unitsToSkill);
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
