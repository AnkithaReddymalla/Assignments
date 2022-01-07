using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlCar
{
    class ExperimentalRemoteControlCar : IRemoteCar
    {
        public int DistanceTravelled = 20;
        public void Drive()
        {
            Console.WriteLine(DistanceTravelled);
        }
    }
}