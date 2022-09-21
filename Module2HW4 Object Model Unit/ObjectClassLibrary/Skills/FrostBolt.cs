using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Interfaces;
using ObjectClassLibrary.Units;
using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.Skills
{
    public sealed class FrostBolt : Skill, IMono, IName
    {
        private float _decreace;
        public FrostBolt(float decreace = 0.1f, string name = "FrostBolt", TypeOfDamage type = TypeOfDamage.Magical, int damage = 10)
            : base(name, type, damage)
        {
            _decreace = decreace;
        }

        public void Cast(Unit target)
        {
            target.Speed -= _decreace;
            target.CurrentHealth -= SDamage;
        }
    }
}
