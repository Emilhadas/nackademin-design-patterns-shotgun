using System;
using System.Collections.Generic;
using System.Text;

namespace Shotgun_1._0
{


    public class Score
    {

        static Score instance;

        protected Score()
        {
        private int playerScore = 0;
        private int computerScore = 0;
    }
        public static Score Instance()
        {
            if (instance == null)
            {
                instance = new Score();
            }
            return instance;
        }

        public int playerScore{get; set;}
        public int computerScore{get; set;}

  }
}
