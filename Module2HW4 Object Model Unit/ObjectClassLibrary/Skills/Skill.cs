using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Skills
{
    public abstract class Skill
    {
        private string _name;
        private TypeOfDamage _typeOfDamage;
        private int _damage;

        public Skill(int damage, string name, TypeOfDamage type)
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
