using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClassLibrary.Weapons
{
    public abstract class Weapon
    {
        private int _damage;
        private TypeOfDamage _damageType;

        public int WDamage
        {
            get
            {
                return _damage;
            }

            set
            {
                _damage = value;
            }
        }

        public TypeOfDamage DamageType
        {
            get
            {
                return _damageType;
            }

            init
            {
                _damageType = value;
            }
        }
    }
}
