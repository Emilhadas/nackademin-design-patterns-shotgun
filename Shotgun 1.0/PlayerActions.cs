using System;
using System.Collections.Generic;
using System.Text;

namespace Shotgun_1._0
{
    class PlayerActions
    {
        public static int PlayerAmmo;

        public  int PlayerChoice(int choice)
        {

            int choiceToCounterWith = choice;

            if (choice == 1)
            {
                PlayerAmmo++;

            }

            else if (choice == 3)
            {
                PlayerAmmo--;
            }

            else if (choice == 4)
            {
                PlayerAmmo -= 3;
            }

            return choiceToCounterWith;
        }

        public int PlayerAmmunition()
        {
            return PlayerAmmo;

        }


        public void ScoreReset()
        {
            PlayerAmmo = 0;
        }
    }
}
