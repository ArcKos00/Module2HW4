using ObjectClassLibrary.Units;
using ObjectClassLibrary.Interfaces;
using UnitControls;
using ObjectClassLibrary.SettingsFiles;

namespace Module2HW4_Object_Model_Unit.Services
{
    internal class Manager
    {
        private static Unit[] _units = UnitControl.GetInstance.Units;
        public static void Starter()
        {
            while (true)
            {
                Drawer.DrawUnits(_units);

                Console.WriteLine("Введите действие: \n 1-Выполнить атаку и каст юнитов, 2-начать поиск по юнитам");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Attacker();
                        Caster();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        _units.Search();
                        break;
                }

                for (int i = 0; i < _units.Length; i++)
                {
                    if (_units[i] != null)
                    {
                        if (_units[i].CurrentHealth <= 0)
                        {
                            _units[i] = null;
                        }
                    }
                }
            }
        }

        private static void Caster()
        {
            Unit[] units = ArrayToCast();

            foreach (ICast cast in units)
            {
                cast.Cast();
            }
        }

        private static void Attacker()
        {
            foreach (IAttack att in _units)
            {
                if (att == null)
                {
                    continue;
                }

                if (att is Goblin)
                {
                    GoblinAttacks(att);
                }
                else if (att is Human)
                {
                    HumanAttacks(att);
                }
            }
        }

        private static void GoblinAttacks(IAttack att)
        {
            int rand = 0;
            while (true)
            {
                rand = new Random().Next(Settings.CountEnemy, _units.Length);
                if (_units[rand] != null)
                {
                    break;
                }
            }

            att.Attack(_units[rand]);
        }

        private static void HumanAttacks(IAttack att)
        {
            int rand = 0;
            while (true)
            {
                rand = new Random().Next(0, Settings.CountEnemy);
                if (_units[rand] != null)
                {
                    break;
                }
            }

            att.Attack(_units[rand]);
        }

        private static Unit[] ArrayToCast()
        {
            int counter = 0;
            for (int i = 0; i < _units.Length; i++)
            {
                if (_units[i] is ICast)
                {
                    counter++;
                }
            }

            Unit[] units = new Unit[counter];
            counter = 0;
            for (int i = 0; i < _units.Length; i++)
            {
                if (_units[i] is ICast)
                {
                    units[counter++] = _units[i];
                }
            }

            return units;
        }
    }
}
