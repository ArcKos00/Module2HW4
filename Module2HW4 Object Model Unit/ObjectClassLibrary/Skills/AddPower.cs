using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Units;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Skills
{
    public sealed class AddPower : Skill, IMore, IName
    {
        public AddPower(string name = "AddPower", TypeOfDamage type = TypeOfDamage.Phisical, int damage = 5)
            : base(name, type, damage)
        {
        }

        public void Cast(Unit[] targets)
        {
            foreach (var target in targets)
            {
                if ((int)target.UGenus == 0 || target.DamageType == TypeOfDamage.Phisical)
                {
                    Cast(target);
                }
            }
        }

        public void Cast(Unit target)
        {
            target.Damage += SDamage;
        }
    }
}
