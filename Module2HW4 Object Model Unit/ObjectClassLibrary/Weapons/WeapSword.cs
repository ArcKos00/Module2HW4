namespace ObjectClassLibrary.Weapons
{
    public class WeapSword : Weapon
    {
        private string _name = "Sword";
        public WeapSword(int damage, TypeOfDamage type = TypeOfDamage.Phisical)
        {
            WDamage = damage;
            DamageType = type;
        }

        public string WName
        {
            get
            {
                return _name;
            }
        }
    }
}
