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
        public static bool IsDegree2(double a)
        {
            bool secondogrado = false;
            if (a != 0)
            {
                secondogrado = true;
            }
            return secondogrado;
        }
        public static double Delta(double a , double b ,double c)
        {
           
            double delta = b*b - (4*a*c);

            return delta;
        }
        public static double Deltanullo( double b, double c)
        {
            double delta = 0;

            return delta;
        }






    }
}
