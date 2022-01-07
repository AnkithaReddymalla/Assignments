using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlCar
{
   static class TestTrack
    {
        
        public static void Race(ProductionRemoteControlCar prod)
        {
     
              Console.WriteLine(prod.DistanceTravelled);
        }
        public static void Race(ExperimentalRemoteControlCar exp)
        {

            Console.WriteLine(exp.DistanceTravelled);
        }
    }
}
