using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }
    }
    class Linq2
    {
        static void Main()
        {
            List<Player> playersList = new List<Player>()
            {
                new Player{Id = 1,Name = "Dhoni",Age = 41,Team = "CSK"},
                new Player{Id = 2,Name = "Rohit",Age = 36,Team = "MI"},
                new Player{Id = 3,Name = "Virat",Age = 35,Team = "RCB"},
                new Player{Id = 3,Name = "Rinku Singh",Age = 25,Team = "KKR"},
                new Player{Id = 4,Name = "Gill",Age = 24,Team = "Gujurat Lion"},
            };
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("All Players List");
            Console.WriteLine("--------------------------------------------------------------");

            foreach (var player in playersList)
            {
                Console.WriteLine("Name : " + player.Name);
                Console.WriteLine("Team : " + player.Team);
                Console.WriteLine("Age : " + player.Age);
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------");
            var youngPlayers = playersList.Where(p => p.Age < 30).ToList();

            Console.WriteLine("Young Players List: ");
            Console.WriteLine("--------------------------------------------------------------");
            foreach (var player in youngPlayers)
            {
                Console.WriteLine("Name : " + player.Name);
                Console.WriteLine("Team : " + player.Team);
                Console.WriteLine("Age : " + player.Age);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
