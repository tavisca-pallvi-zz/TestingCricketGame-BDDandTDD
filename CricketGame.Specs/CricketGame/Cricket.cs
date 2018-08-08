using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
       // public int Score;
        public int PlayerScore { get; set; }
        public Cricket()
        {
            PlayerScore = 0;
        }

        public void Score(int runs)
        {
          //  if (runs < 7)
            
                PlayerScore = PlayerScore + runs;
            
          
        }

       /* public void AddedScore(int runs)
        {
          
                PlayerScore = PlayerScore+runs;
            
            // throw new NotImplementedException();
        }
        */

    }
}
