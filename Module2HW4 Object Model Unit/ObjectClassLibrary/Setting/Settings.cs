using ObjectClassLibrary.Weapons;

namespace ObjectClassLibrary.SettingsFiles
{
    public static class Settings
    {
        public static int CountEnemy { get; } = 1;

        // Goblin characteristic
        public static string GoblinName { get; } = "Гоблин";
        public static int GoblinHealth { get; } = 1000;
        public static int GoblicDamage { get; } = 15;
        public static int GoblinArmor { get; } = 15;

        // Human characteristic
        public static string HumanName { get; } = "Человек";
        public static int HumanHealth { get; } = 20;
        public static int HumanDamage { get; } = 5;

        // Soldier characteristic
        public static string SoldierName { get; } = "Солдат";
        public static int SoldierHealth { get; } = 25;
        public static int SoldierDamage { get; } = 4;
        public static int SoldierArmor { get; } = 2;
        public static float SoldierSpeed { get; } = 0.75f;
        public static WeapSword SoldierSword { get; } = new WeapSword(4);

        // Warrior characteristic
        public static string WarriorName { get; } = "Воин";
        public static int WarriorHealth { get; } = 40;
        public static int WarriorDamage { get; } = 5;
        public static int WarriorArmor { get; } = 3;
        public static float WarriorSpeed { get; } = 0.85f;
        public static WeapSword WarriorSword { get; } = new WeapSword(7);

        // WarriorElite characterictic
        public static string EliteWarriorName { get; } = "Элитный Воин";
        public static int EliteWarriorHealth { get; } = 50;
        public static int EliteWarriorDamage { get; } = 7;
        public static int EliteWarriorArmor { get; } = 5;
        public static float EliteWarriorSpeed { get; } = 0.85f;
        public static WeapSword EliteWarriorSword { get; } = new WeapSword(8);

        // MageStudent characteristic
        public static string StudentMageName { get; } = "Маг-студент";
        public static int StudentMageHealth { get; } = 25;
        public static int StudentMageDamage { get; } = 0;
        public static int StudentMageArmor { get; } = 1;

        // Mage characteristic
        public static string MageName { get; } = "Маг";
        public static int MageHealth { get; } = 30;
        public static int MageDamage { get; } = 3;
        public static int MageArmor { get; } = 2;
        public static WeapWizzardStaff MageStaff { get; } = new WeapWizzardStaff(3);

        // TheUpperMage characteristic
        public static string UpperMageName { get; } = "Верховный Маг";
        public static int UpperMageHealth { get; } = 35;
        public static int UpperMageDamage { get; } = 3;
        public static int UpperMageArmor { get; } = 3;
        public static WeapWizzardStaff UpperMageStaff { get; } = new WeapWizzardStaff(4);
    }
}
