using ObjectClassLibrary.Units;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Skills
{
    public sealed class Charge : Skill, IMono, IName
    {
        public Charge(int damage = 10, string name = "Charge", TypeOfDamage type = TypeOfDamage.Phisical)
            : base(damage, name, type)
        {
        }

        public void Cast(Unit target)
        {
            Console.WriteLine();
            Console.WriteLine($"Наносит урон {target.Name} Рывком с уроном {SDamage}");
            target.CurrentHealth -= SDamage;
        }
    }
}
