using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach (var unit in target)
            {
                unit.CurrentHealth += SDamage;
            }
        }
    }
}
