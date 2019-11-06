using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Player
    {
        //remove set to make it read only, Private only allows score to be changed from inside class
        public int ID { get; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
    
        public static int HighScore { get; private set; }
        // ctor is constructor shortcut
        public Player(int id,string playerName, int score)
        {
            ID = id;
            PlayerName = playerName;
            Score = score;

        }
        public void IncreaseScore(int valueToAdd)
        {
            if (Score <100)
            Score += valueToAdd;
            //check for highscore
            if (Score > HighScore)
                HighScore = Score;
        }
        public override string ToString()
        {
            //formatting string
            
            return $"{ID}\t{PlayerName}\t{Score}";
        }
    }
}
