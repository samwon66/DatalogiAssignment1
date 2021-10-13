using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatalogiAssignment1.Utilities
{
    public static class Utils
    {
        /// <summary>
        /// Kolla om ett heltal är primtal.
        /// Om talet är 1 eller mindre, så är det inget primtal och 2 är ett primtal.
        /// Sen kollar man från 2 t.o.m. det talet som är kvadraten av heltalet som angett.
        /// </summary>
        /// <param name="nr">ett heltal som ska kollas.</param>
        /// <returns>true om det är primtal, annars false.</returns>
        public static bool PrimeCheck(int nr)
        {
            if (nr <= 1) return false;
            if (nr == 2) return true;
            var stop = Math.Round(Math.Sqrt(nr));
            for (int i = 2; i <= stop; i++)
            {
                if (nr % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
