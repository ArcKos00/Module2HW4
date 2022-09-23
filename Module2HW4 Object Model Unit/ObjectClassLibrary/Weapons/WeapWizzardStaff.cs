namespace ObjectClassLibrary.Weapons
{
    public class WeapWizzardStaff : Weapon
    {
        public WeapWizzardStaff(int damage, TypeOfDamage type = TypeOfDamage.Magical)
        {
            WDamage = damage;
            DamageType = type;
        }
    }
}
