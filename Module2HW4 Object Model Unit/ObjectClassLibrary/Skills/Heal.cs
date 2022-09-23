using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Units;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Skills
{
    public sealed class Heal : Skill, IMore, IName
    {
        public Heal(int damage = 30, string name = "Heal", TypeOfDamage type = TypeOfDamage.Magical)
            : base(damage, name, type)
        {
        }

        public void Cast(Unit[] target)
        {
            Console.WriteLine();
            foreach (var unit in target)
            {
                Console.WriteLine($"Восстанавливает жизни {unit.Name} количеством {SDamage}");
                unit.CurrentHealth += SDamage;
            }
        }
    }
}
