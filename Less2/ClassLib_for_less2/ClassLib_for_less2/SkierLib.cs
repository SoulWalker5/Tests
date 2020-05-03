using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_for_less2
{
    public class SkierLib
    {
        public int Skier(double kmperday, double km, double allkm, int percent, int days)
        {
            if (km == 0 || percent == 0 || days == 0)
            {
                return 0;
            }

            else if (km == int.MinValue || percent == int.MinValue || days == int.MaxValue || days == int.MinValue)
            {
                return 0;
            }

            else if (allkm == int.MaxValue || km == int.MaxValue )
            {
                return days;
            }

            for (double i = km; i < allkm && i != allkm; i += kmperday)
            {
                kmperday = ((km / 100) * percent);
                days++;
            }

            return days;
        }
    }
}
