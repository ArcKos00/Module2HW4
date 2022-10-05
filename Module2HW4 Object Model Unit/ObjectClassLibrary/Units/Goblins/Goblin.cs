using UnitControls;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Units.Enums;

namespace ObjectClassLibrary.Units
{
    public class Goblin : Unit, IMove, IAttack, ICast
    {
        private Skill[] _spells = new Skill[] { new Charge(20), new Heal() };
        public Goblin(int damage, string name, int health, int armor, UnitsType type)
            : base(health, type)
        {
            Armor = armor;
            UGenus = Genus.Goblin;
            Damage = damage;
            Name = name;
        }

        public void Cast()
        {
            Console.WriteLine($"Виберите спообность которую использует {Name}: ");
            Console.WriteLine("1-Charge, 2-Heal");
            Unit[] units = UnitControl.GetInstance.Units;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    for (int i = 0; i < _spells.Length; i++)
                    {
                        if (_spells[i] is IMono && _spells[i] is Charge)
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

                            (_spells[i] as IMono).Cast(units[rand]);
                            break;
                        }
                    }

                    break;
                case ConsoleKey.D2:
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
                                    rand = new Random().Next(0, Settings.CountEnemy);
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

        public void Attack(Unit target)
        {
            int damage = Damage - (target.Armor * 4 / 5);
            if (damage < 0)
            {
                damage = 0;
            }

            target.CurrentHealth -= damage;
            Console.WriteLine($"{Name} атакует {target.Name} с уроном {damage}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Damage}");
        }
    }
}
