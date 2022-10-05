using ObjectClassLibrary.Units;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Skills
{
    public sealed class AddPower : Skill, IMore, IName
    {
        public AddPower(int damage = 5, string name = "AddPower", TypeOfDamage type = TypeOfDamage.Phisical)
            : base(damage, name, type)
        {
        }

        public void Cast(Unit[] targets)
        {
            foreach (var target in targets)
            {
                    Cast(target);
            }
        }

        public void Cast(Unit target)
        {
            Console.WriteLine();
            Console.WriteLine($"Увеличивает урон {target.Name}");
            target.Damage += SDamage;
        }
    }
}
