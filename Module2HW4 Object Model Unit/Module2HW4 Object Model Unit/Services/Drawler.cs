using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Units;

namespace Module2HW4_Object_Model_Unit.Services
{
    internal class Drawler
    {
        public static void Drawle(Unit[] units)
        {
            Console.Clear();
            for (int i = 0; i < units.Length; i++)
            {
                if (units[i] != null)
                {
                    Draw(units[i]);
                }
            }
        }

        public static void Draw(Unit unit)
        {
            Console.WriteLine($"{unit.UGenus}");
            Console.WriteLine($"Имя: {unit.Name}");
            Console.WriteLine($"Урон: {unit.Damage}");
            Console.WriteLine($"Здоровье: {unit.CurrentHealth}");
            Console.WriteLine($"Защита: {unit.Armor}");
            Console.WriteLine("================================");
        }
    }
}
