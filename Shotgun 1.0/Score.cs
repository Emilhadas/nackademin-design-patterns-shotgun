using System;
using System.Collections.Generic;
using System.Text;

namespace Shotgun_1._0
{


    public class Score
    {

        static Score instance;
        



        public Score()
        {
            
        }

        public int playerScore { get; set; }


        public int computerScore { get; set; }

        public static Score Instance()
        {
            if (instance == null)
            {
                instance = new Score();
               
            }
            return instance;
        }


        
        public void ResetScore()
        {
            playerScore = 0;
            computerScore = 0;
        }

        

    }
}
