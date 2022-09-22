using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClassLibrary.Units;

namespace UnitControl
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
        }

        private void RandomSpawner()
        {
            for (int i = 0; i < Settings.CountEnemy; i++)
            {
                _units[i] = Spawner.Spawn(0);
            }

            for (int i = Settings.CountEnemy; i < _units.Length; i++)
            {
                _units[i] = Spawner.Spawn(new Random().Next(1, 8));
            }
        }
    }
}
