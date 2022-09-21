using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Skills
{
    public abstract class Skill
    {
        private string _name;
        private TypeOfDamage _typeOfDamage;
        private int _damage;

        public Skill(string name, TypeOfDamage type, int damage)
        {
            SName = name;
            STypeOfDAmage = type;
            SDamage = damage;
        }

        public string SName
        {
            get { return _name; }
            init { _name = value; }
        }

        public TypeOfDamage STypeOfDAmage
        {
            get { return _typeOfDamage; }
            init { _typeOfDamage = value; }
        }

        public int SDamage
        {
            get { return _damage; }
            init { _damage = value; }
        }
    }
}
