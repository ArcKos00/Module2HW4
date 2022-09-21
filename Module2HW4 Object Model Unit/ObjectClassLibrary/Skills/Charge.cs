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
    public sealed class Charge : Skill, IMono, IName
    {
        public Charge(int damage = 10, string name = "Charge", TypeOfDamage type = TypeOfDamage.Phisical)
            : base(name, type, damage)
        {
        }

        public void Cast(Unit target)
        {
            target.CurrentHealth -= SDamage;
        }
    }
}
