using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazione
    {
      public static bool IsDetermined(double a , double b)
        {
            bool flag = true;

            if(a!= 0 && b!=0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        



    }
}
