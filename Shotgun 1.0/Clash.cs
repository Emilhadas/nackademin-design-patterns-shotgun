using System;
using System.Collections.Generic;
using System.Text;

namespace Shotgun_1._0
{
    class Clash
    {
        public static int pA;
        public static int cA;
        public static string  Result;

        public string Fight(int choice)
        {


            PlayerActions pa = new PlayerActions();
            CpuActions ca = new CpuActions();


            pA = pa.PlayerChoice(choice);
            cA = ca.Action();



            if (pA == 1 && cA != 3 && cA != 4)
            {
                Result = "Reloaded Successfully";
                return Result;

            }

            else if (pA == 1 && cA == 3 || (cA == 4 && pA != 4))
            {
                Result = "You Lose";
                return Result;

            }

            else if (pA == 2 && cA == 3)
            {
                Result = "You Block a Shot";
                return Result;

            }
            else if (pA == 2 && cA == 4)
            {
                Result = "You Lose";
                return Result;

            }


            else if (pA == 3 && cA == 1)
            {
                Result = "You Win!";
                return Result;

            }
            else if (pA == 3 && cA == 2)
            {
                Result = "You were Blocked";
                return Result;

            }
            else if (pA == 3 && cA == 4)
            {
                Result = "You Lose";
                return Result;

            }
            else if (pA == 2 && cA == 1)
            {
                Result = "You blocked air, enemy reloaded successfully";
                return Result;
            }
            else if (pA == 4 && cA != 4)
            {
                Result = "You Win!";
                return Result;
            }
            else
            {
                Result = "You both countered eachother";
                return Result;

            }   
        }
    }
}
