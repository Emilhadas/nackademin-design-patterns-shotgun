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
      
    } 
    public static Score Instance()
    {
            if (instance == null)
            {
                instance = new Score();
            }
        return instance;
    }
       


  }
}
