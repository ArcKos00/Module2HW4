using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Skills;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Units
{
    public class MageStudent : Human, IMove, IAttack
    {
        private FireBall _spell = new FireBall();
        public MageStudent(string name, int health, int damage)
            : base(name, health, damage)
        {
            Armor += 1;
            DamageType = Weapons.TypeOfDamage.Magical;
        }

        void IAttack.Attack(Unit target)
        {
            Console.WriteLine($"{Name} кастует фаерболл в {target.Name} и наносит урон {_spell.SDamage}");
            _spell.Cast(target);
        }

        void IMove.Move()
        {
            Console.WriteLine($"{Name} идет со скоростью {Speed}");
        }
    }
}
