using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_M1_Problem2
{
   
    class PlayerImplementation
    {
        int listCount;

        public int Average(IList<Player> players)
        {
            int count = 0;
            int avg = 0;
            foreach (var item in players)
            {
                avg = avg + item.Score;
                count++;
            }
            avg = avg / count;
            listCount = count;
            return avg;
        }

        public int Max(IList<Player> players)
        {
            int maxScore = players[0].Score;
            for(int i=1; i<listCount; i++ )
            {
                if(maxScore < players[i].Score )
                {
                    maxScore = players[i].Score;
                }
            }
            return maxScore;

        }

        public int Min(IList<Player> players)
        {
            int minScore = players[0].Score;
            for (int i = 1; i < listCount; i++)
            {
                if (minScore > players[i].Score)
                {
                    minScore = players[i].Score;
                }
            }
            return minScore;

        }
    }
}
