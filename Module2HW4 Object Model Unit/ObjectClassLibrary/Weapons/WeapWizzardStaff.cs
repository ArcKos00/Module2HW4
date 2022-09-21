using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClassLibrary.Weapons
{
    public class WeapWizzardStaff : Weapon
    {
        public WeapWizzardStaff(int damage, TypeOfDamage type = TypeOfDamage.Magical)
        {
            WDamage = damage;
            DamageType = type;
        }
    }
}
