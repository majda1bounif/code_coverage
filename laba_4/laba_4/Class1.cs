using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4
{
    public class CircleClass
    {
        public bool Coordinate(double x, double y, double R)
        {
            if (x <= 0 && y >= 0 && x >= (R * (-1)) && y <= R && Math.Sqrt((x * x) + (y * y)) <= R ||
                x >= 0 && y <= 0 && x >= R / 2 && y >= (-2 * x) ||
                (R - x < R / 2) && y <= ((2 * x) - (2 * R)))
                return true;
            else return false;
        }
    }
}