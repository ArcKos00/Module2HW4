using ObjectClassLibrary.Units;

namespace UnitControls
{
    public class UnitControl
    {
        private static UnitControl _instance = new UnitControl();
        private Unit[] _units;
        private UnitControl()
        {
            Console.WriteLine("Введите количество юнитов");
            _units = new Unit[int.Parse(Console.ReadLine())];
            RandomSpawner();
        }

        public static UnitControl GetInstance
        {
            get
            {
                return _instance;
            }
            set
            {
                if (_instance == null)
                {
                    _instance = new UnitControl();
                }
            }
        }

        public Unit[] Units
        {
            get { return _units; }
            set { _units = value; }
        }

        private void RandomSpawner()
        {
            if (_units.Length < 10)
            {
                Settings.CountEnemy = 1;
            }
            else
            {
                Settings.CountEnemy = _units.Length / 10;
            }

            for (int i = 0; i < Settings.CountEnemy; i++)
            {
                _units[i] = Spawner.SpawnGoblin();
            }

            for (int i = Settings.CountEnemy; i < _units.Length; i++)
            {
                switch (new Random().Next(0, 7))
                {
                    case 0:
                        _units[i] = Spawner.SpawnHuman();
                        break;
                    case 1:
                        _units[i] = Spawner.SpawnSoldier();
                        break;
                    case 2:
                        _units[i] = Spawner.SpawnWarrior();
                        break;
                    case 3:
                        _units[i] = Spawner.SpawnWarriorElite();
                        break;
                    case 4:
                        _units[i] = Spawner.SpawnMageStudent();
                        break;
                    case 5:
                        _units[i] = Spawner.SpawnMage();
                        break;
                    case 6:
                        _units[i] = Spawner.SpawnUpperMage();
                        break;
                }

                _units[i].Name += i.ToString();
            }
        }
    }
}
