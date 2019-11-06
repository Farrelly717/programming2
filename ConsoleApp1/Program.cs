using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);
            //List part6
            List<Player> allPlayers = new List<Player>();

            allPlayers.Add(player1);
            allPlayers.Add(player2);
            allPlayers.Add(player3);
            allPlayers.Add(player4);
            allPlayers.Add(player5);

            //increase score 
            // player1.IncreaseScore(1);
            // player2.IncreaseScore(10);

            //runs method to displaytable
            Display(allPlayers);
            //loop asking for player number
           Console.WriteLine("Please enter the number of the player you wish to add score for");
           string response = Console.ReadLine();
           int playerNumber = int.Parse(response);
          
            Getscores(allPlayers, ref response, ref playerNumber);
            DisplayPlayerDetails(allPlayers);

        }

        private static void Getscores(List<Player> allPlayers, ref string response, ref int playerNumber)
        {
            while (playerNumber != 0)
            {
                //determine player selected
                Player selectedPlayer = allPlayers.ElementAt(playerNumber - 1);//string starts at 0, playernum stats at 1

                //increase score for that player
                selectedPlayer.IncreaseScore(1);

                //display results
                Display(allPlayers);

                //ask for another player or 0 toquit
                Console.WriteLine("Please enter the number of the player you wish to add score for");
                response = Console.ReadLine();
                playerNumber = int.Parse(response);

            }
        }

        private static void Display (List<Player>players)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Player1", "Player2", "Player3", "Player4", "Player5");
           
            //loop through all players in list and display scores foreach
            foreach (Player player in players)
            {
                Console.Write("{0,-10}",player.Score);
            }
            Console.WriteLine();

        }
        private static void DisplayPlayerDetails(List<Player> players)
        {
            Console.WriteLine($"{"ID"}\t{"Name"}\t{"Score"}");
            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
