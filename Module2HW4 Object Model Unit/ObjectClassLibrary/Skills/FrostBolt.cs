using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Units;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Skills
{
    public sealed class FrostBolt : Skill, IMono, IName
    {
        private float _decreace;
        public FrostBolt(int damage = 10, float decreace = 0.1f, string name = "FrostBolt", TypeOfDamage type = TypeOfDamage.Magical)
            : base(damage, name, type)
        {
            _decreace = decreace;
        }

        public void Cast(Unit target)
        {
            Console.WriteLine();
            Console.WriteLine($"Наносит урон {target.Name} Фростболтом с уроном {SDamage}");
            target.Speed -= _decreace;
            target.CurrentHealth -= SDamage;
        }
    }
}
