global using ObjectClassLibrary.SettingsFiles;
using ObjectClassLibrary.Units;
using ObjectClassLibrary.Units.Enums;

namespace ObjectClassLibrary.SettingsFiles
{
    internal static class Spawner
    {
        public static Unit SpawnGoblin()
        {
            return new Goblin(
                        Settings.GoblicDamage,
                        Settings.GoblinName,
                        Settings.GoblinHealth,
                        Settings.GoblinArmor,
                        UnitsType.Goblin);
        }

        public static Unit SpawnHuman()
        {
            return new Human(
                        Settings.HumanName,
                        Settings.HumanHealth,
                        Settings.HumanDamage,
                        UnitsType.Human);
        }

        public static Unit SpawnSoldier()
        {
            return new Soldier(
                        Settings.SoldierName,
                        Settings.SoldierHealth,
                        Settings.SoldierDamage,
                        Settings.SoldierArmor,
                        Settings.SoldierSpeed,
                        Settings.SoldierSword,
                        UnitsType.Soldier);
        }

        public static Unit SpawnWarrior()
        {
            return new Warrior(
                        Settings.WarriorName,
                        Settings.WarriorHealth,
                        Settings.WarriorDamage,
                        Settings.WarriorArmor,
                        Settings.WarriorSpeed,
                        Settings.WarriorSword,
                        UnitsType.Warrior);
        }

        public static Unit SpawnWarriorElite()
        {
            return new WarriorElite(
                        Settings.EliteWarriorName,
                        Settings.EliteWarriorHealth,
                        Settings.EliteWarriorDamage,
                        Settings.EliteWarriorArmor,
                        Settings.EliteWarriorSpeed,
                        Settings.EliteWarriorSword,
                        UnitsType.EliteWarrior);
        }

        public static Unit SpawnMageStudent()
        {
            return new MageStudent(
                        Settings.StudentMageName,
                        Settings.StudentMageHealth,
                        Settings.StudentMageDamage,
                        Settings.StudentMageArmor,
                        UnitsType.StudentMage);
        }

        public static Unit SpawnMage()
        {
            return new Mage(
                       Settings.MageName,
                       Settings.MageHealth,
                       Settings.MageDamage,
                       Settings.MageArmor,
                       Settings.MageStaff,
                       UnitsType.Mage);
        }

        public static Unit SpawnUpperMage()
        {
            return new UpperMage(
                        Settings.UpperMageName,
                        Settings.UpperMageHealth,
                        Settings.UpperMageDamage,
                        Settings.UpperMageArmor,
                        Settings.UpperMageStaff,
                        UnitsType.UpperMage);
        }
    }
}
