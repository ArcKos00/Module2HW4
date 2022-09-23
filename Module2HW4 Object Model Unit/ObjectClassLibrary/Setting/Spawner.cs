global using ObjectClassLibrary.SettingsFiles;
using ObjectClassLibrary.Units;

namespace ObjectClassLibrary.SettingsFiles
{
    internal static class Spawner
    {
        public static Unit Spawn(int value)
        {
            switch (value)
            {
                case 0:
                    return new Goblin(
                        Settings.GoblicDamage,
                        Settings.GoblinName,
                        Settings.GoblinHealth,
                        Settings.GoblinArmor);
                case 1:
                    return new Human(
                        Settings.HumanName,
                        Settings.HumanHealth,
                        Settings.HumanDamage);
                case 2:
                    return new Soldier(
                        Settings.SoldierName,
                        Settings.SoldierHealth,
                        Settings.SoldierDamage,
                        Settings.SoldierArmor,
                        Settings.SoldierSpeed,
                        Settings.SoldierSword);
                case 3:
                    return new Warrior(
                        Settings.WarriorName,
                        Settings.WarriorHealth,
                        Settings.WarriorDamage,
                        Settings.WarriorArmor,
                        Settings.WarriorSpeed,
                        Settings.WarriorSword);
                case 4:
                    return new WarriorElite(
                        Settings.EliteWarriorName,
                        Settings.EliteWarriorHealth,
                        Settings.EliteWarriorDamage,
                        Settings.EliteWarriorArmor,
                        Settings.EliteWarriorSpeed,
                        Settings.EliteWarriorSword);
                case 5:
                    return new MageStudent(
                        Settings.StudentMageName,
                        Settings.StudentMageHealth,
                        Settings.StudentMageDamage,
                        Settings.StudentMageArmor);
                case 6:
                    return new Mage(
                        Settings.MageName,
                        Settings.MageHealth,
                        Settings.MageDamage,
                        Settings.MageArmor,
                        Settings.MageStaff);
                case 7:
                    return new UpperMage(
                        Settings.UpperMageName,
                        Settings.UpperMageHealth,
                        Settings.UpperMageDamage,
                        Settings.UpperMageArmor,
                        Settings.UpperMageStaff);
                default:
                    return null;
            }
        }
    }
}
