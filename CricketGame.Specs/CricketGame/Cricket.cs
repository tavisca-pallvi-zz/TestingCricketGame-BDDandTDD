using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public bool isOut;
        public int PlayerScore { get; set; }
        public bool isWinner;
        public Cricket()
        {
            PlayerScore = 0;
            isOut = false;
          //  isWinner = false;

        }
        public void Score(int runs)
        {

            if (isOut == false)
                PlayerScore = PlayerScore + runs;
            
          
        }
        public void GetOut()
        {
            this.isOut = true;


        }

        public void Winner(Cricket secondPlayer)
        {
            if (this.PlayerScore > secondPlayer.PlayerScore)
                this.isWinner = true;
            else if (secondPlayer.PlayerScore > this.PlayerScore)
                secondPlayer.isWinner = true;
            else
            {
                this.isWinner = true;
                secondPlayer.isWinner = true;
            }

        }


    }
}
