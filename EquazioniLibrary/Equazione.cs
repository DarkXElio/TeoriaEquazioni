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

        public static bool IsInconsisted(double a)
        {
            bool impossibile = false;

            if (a == 0)
            {
                impossibile = true;
            }
           
            return impossibile;
        }

       



    }
}
