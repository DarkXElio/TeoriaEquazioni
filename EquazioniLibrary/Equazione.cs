using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazione
    {
      public static bool IsDetermined(double a)
        {
            bool determinato = false;

            if(a!= 0)
            {
                determinato = true;
            }
            return determinato;
        }

        public static bool IsInconsisted(double a, double b)
        {
            bool impossibile = true;

            if (a == 0 && b != 0)
            {
                impossibile = true;
            }
            else
            {
                impossibile = false;
            }
            return impossibile;
        }

       



    }
}
