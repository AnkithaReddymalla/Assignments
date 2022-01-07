using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
 static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            double successRate = 0;
            if (speed == 0)
            {
                successRate = 0;
            }
            else if (speed >= 1 && speed <= 4)
            {
                successRate = 1;
            }
            else if (speed >= 5 && speed <= 8)
            {
                successRate = 0.9;
            }
            else if (speed == 9)
            {
                successRate = 0.8;
            }
            else if (speed == 10)
            {
                successRate = 0.77;
            }
            return successRate;
        }
        public static double ProductionRatePerHour(int speed)
        {
            return speed * 221;

        }
        public static int WorkingItemsPerMinute(int speed)
        {
            return (speed * 221) / 60;
        }

    }
}
