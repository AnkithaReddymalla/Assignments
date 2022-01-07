using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_M1_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Player> players = new List<Player>();
            players.Add(new Player { Name = "X", Team = "A", Score = 30 });
            players.Add(new Player { Name = "X", Team = "A", Score = 90 });
            players.Add(new Player { Name = "X", Team = "A", Score = 50 });
            PlayerImplementation playerImplementation = new PlayerImplementation();
            Console.WriteLine("Average Score: "+playerImplementation.Average(players));
            Console.WriteLine("Maximum Score: "+playerImplementation.Max(players));
            Console.WriteLine("Minimum Score: "+playerImplementation.Min(players));
            Console.ReadKey();
        }
    }
}
