﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Units;
using ObjectClassLibrary.Weapons;
using ObjectClassLibrary.Interfaces;

namespace ObjectClassLibrary.Skills
{
    public class FireBall : Skill, IMono, IName
    {
        private int _decreace;
        public FireBall(int decreace = 1, string name = "FireBall", TypeOfDamage type = TypeOfDamage.Magical, int damage = 10)
            : base(name, type, damage)
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
            target.Damage -= SubDamage;
            target.CurrentHealth -= SDamage;
        }
    }
}