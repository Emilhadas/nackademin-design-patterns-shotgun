using System;
using System.Collections.Generic;
using System.Text;

namespace Shotgun_1._0
{
    class CpuActions
    {

        public static int CpuAmmo = 0;
        public static int actionNr= 1;
        bool firstRound = true;
        public void ActionRandomiser()
        {
            Form1 fr = new Form1();
            if (CpuAmmo == 0 && firstRound == true)
            {
                actionNr = 1;
                firstRound = false;
            }
            else if (CpuAmmo == 0 && firstRound == false)
            {
                actionNr = fr.ComputerRandom();
            }
            else if (CpuAmmo > 0 && CpuAmmo < 3)
            {
                actionNr = fr.ComputerRandom();
            }
            else if (CpuAmmo >= 3)
            {
                actionNr = 4;
            }

        }

        public int Action()
        {
            ActionRandomiser();
            int finalAction = actionNr;
            if (CpuAmmo == 3)
            {
                finalAction = 4;
                CpuAmmo -= 3;
                return finalAction;

            }

            else
            {
                if (finalAction == 1)
                {
                    CpuAmmo++;
                }
                else if (finalAction == 3)
                {
                    CpuAmmo--;
                }
                
                return finalAction;


            }


        }



        public int GetCpuAmmo()
        {
            return CpuAmmo;
        }

        public int GetAction()
        {
            return actionNr;
        }
        public void ScoreReset()
        {
            firstRound = true;
            CpuAmmo = 0;
        }
    }
}
