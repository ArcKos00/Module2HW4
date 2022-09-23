using ObjectClassLibrary.Units;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Skills
{
    public class FireBall : Skill, IMono, IName
    {
        private int _decreace;
        public FireBall(int damage = 10, int decreace = 1, string name = "FireBall", TypeOfDamage type = TypeOfDamage.Magical)
            : base(damage, name, type)
        {
            _decreace = decreace;
        }

        public int SubDamage
        {
            get { return _decreace; }
            init { _decreace = value; }
        }

        public void Cast(Unit target)
        {
            Console.WriteLine();
            Console.WriteLine($"Наносит урон {target.Name} Фаерболом с уроном {SDamage}");
            target.Damage -= SubDamage;
            target.CurrentHealth -= SDamage;
        }
    }
}
