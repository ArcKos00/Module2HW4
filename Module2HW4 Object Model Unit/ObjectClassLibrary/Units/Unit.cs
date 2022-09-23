using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Units.Enums;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Units
{
    public abstract class Unit : IMove
    {
        private Genus _genus;
        private TypeOfDamage _damageType;
        private int _damage;
        private int _health;
        private int _currentHealth;
        private int _armor = 0;
        private float _speed = 1;
        private string _name;
        private UnitsType _type;

        public Unit(int health)
        {
            _currentHealth = health;
            _health = health;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Genus UGenus
        {
            get { return _genus; }
            init { _genus = value; }
        }

        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int Health
        {
            get { return _health; }
            init { _health = value; }
        }

        public int CurrentHealth
        {
            get { return _currentHealth; }
            set { _currentHealth = value; }
        }

        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        public TypeOfDamage DamageType
        {
            get { return _damageType; }
            set { _damageType = value; }
        }

        public UnitsType UnitType
        {
            get { return _type; }
            init { _type = value; }
        }

        public virtual void Move()
        {
            Console.WriteLine($"Юнит ходит со скоростью {_speed}");
        }
    }
}