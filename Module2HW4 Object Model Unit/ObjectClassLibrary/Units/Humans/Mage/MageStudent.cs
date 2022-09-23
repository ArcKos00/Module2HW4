using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Units.Enums;

namespace ObjectClassLibrary.Units
{
    public class MageStudent : Human, IMove, IAttack
    {
        private FireBall _spell = new FireBall(5);
        public MageStudent(string name, int health, int damage, int armor, UnitsType type)
            : base(name, health, damage, type)
        {
            Armor += armor;
            DamageType = Weapons.TypeOfDamage.Magical;
        }

        public override void Attack(Unit target)
        {
            Console.WriteLine($"{Name} кастует фаерболл в {target.Name} и наносит урон {_spell.SDamage}");
            _spell.Cast(target);
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Speed}");
        }
    }
}
