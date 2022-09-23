using UnitControls;
using ObjectClassLibrary.Units;
using ObjectClassLibrary.Units.Enums;

namespace Module2HW4_Object_Model_Unit
{
    public static class SearchEngine
    {
        public static void Search(this Unit[] units)
        {
            Console.WriteLine("Выполнить поиск по Расе - 1, Выполнить поиск по юниту - 2, Выполнить поиск по характеристике - 3: ");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    units.SearchForGenus();
                    break;
                case ConsoleKey.D2:
                    units.SearchForUnit();
                    break;
                case ConsoleKey.D3:
                    SearchForStats();
                    break;
            }
        }

        private static void SearchForGenus(this Unit[] units)
        {
            Console.WriteLine("Выберите расу:");
            string[] genus = Enum.GetNames(typeof(Genus));
            for (int i = 0; i < genus.Length; i++)
            {
                Console.Write($"{i + 1} {genus[i]} ");
            }

            Console.WriteLine();

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UGenus == Genus.Human)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UGenus == Genus.Goblin)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
            }

            Console.ReadKey();
        }

        private static void SearchForUnit(this Unit[] units)
        {
            Console.WriteLine("Выберите тип юнита:");
            string[] unitsArr = Enum.GetNames(typeof(UnitsType));
            for (int i = 0; i < unitsArr.Length; i++)
            {
                Console.WriteLine($"{i + 1} {unitsArr[i]} ");
            }

            Console.WriteLine();

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UnitType == UnitsType.Goblin)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UnitType == UnitsType.Human)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D3:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UnitType == UnitsType.Soldier)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D4:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UnitType == UnitsType.Warrior)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D5:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UnitType == UnitsType.EliteWarrior)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D6:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UnitType == UnitsType.StudentMage)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D7:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UnitType == UnitsType.Mage)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D8:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].UnitType == UnitsType.UpperMage)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
            }

            Console.ReadKey();
        }

        private static void SearchForStats()
        {
            Console.WriteLine();
            Console.WriteLine("Поиск по имени-1, поиск по атаке-2, поиск по количеству жизней-3, \nпоиск по броне-4, поиск по скорости передвижения-5");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    SearchForName();
                    break;
                case ConsoleKey.D2:
                    SearchForDamage();
                    break;
                case ConsoleKey.D3:
                    SearchForHealth();
                    break;
                case ConsoleKey.D4:
                    SearchForArmor();
                    break;
                case ConsoleKey.D5:
                    SearchForSpeed();
                    break;
            }

            Console.ReadKey();
        }

        private static void SearchForName()
        {
            Console.WriteLine();
            Unit[] units = UnitControl.GetInstance.Units;
            Console.WriteLine("Введите имя для поиска: ");
            string? searchstr = Console.ReadLine();
            for (int i = 0; i < units.Length; i++)
            {
                if (units[i] != null)
                {
                    if (units[i].Name == searchstr)
                    {
                        Drawler.Draw(units[i]);
                    }
                }
            }
        }

        private static void SearchForDamage()
        {
            Console.WriteLine();
            Console.WriteLine("Введите значение поиска: ");
            Unit[] units = UnitControl.GetInstance.Units;
            int searchDamage = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите направление поиска: \n1-меньше чем указано, \n2-поиск по этому значению, \n3-больше этого значения");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].Damage < searchDamage)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].Damage == searchDamage)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D3:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].Damage > searchDamage)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
            }
        }

        private static void SearchForHealth()
        {
            Console.WriteLine();
            Console.WriteLine("Введите значение поиска: ");
            Unit[] units = UnitControl.GetInstance.Units;
            int searchHealth = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите направление поиска: \n1-меньше чем указано, \n2-поиск по этому значению, \n3-больше этого значения");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].CurrentHealth < searchHealth)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].CurrentHealth == searchHealth)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D3:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].CurrentHealth > searchHealth)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
            }
        }

        private static void SearchForArmor()
        {
            Console.WriteLine();
            Console.WriteLine("Введите значение поиска: ");
            Unit[] units = UnitControl.GetInstance.Units;
            int searchArmor = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите направление поиска: \n1-меньше чем указано, \n2-поиск по этому значению, \n3-больше этого значения");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].Armor < searchArmor)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].Armor == searchArmor)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D3:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].Armor > searchArmor)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
            }
        }

        private static void SearchForSpeed()
        {
            Console.WriteLine();
            Unit[] units = UnitControl.GetInstance.Units;
            Console.WriteLine("Введите значение поиска: ");
            Console.WriteLine("(Минимальная скоростьюнитов: 0.75, Максимальная скорость юнитов: 1)");
            float searchDamage = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите направление поиска: \n1-меньше чем указано, \n2-поиск по этому значению, \n3-больше этого значения");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].Damage < searchDamage)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D2:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].Damage == searchDamage)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
                case ConsoleKey.D3:
                    for (int i = 0; i < units.Length; i++)
                    {
                        if (units[i] != null)
                        {
                            if (units[i].Damage > searchDamage)
                            {
                                Drawler.Draw(units[i]);
                            }
                        }
                    }

                    break;
            }
        }
    }
}
