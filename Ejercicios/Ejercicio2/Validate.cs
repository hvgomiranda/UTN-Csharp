using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Validate
    {
        public static bool ValidateInt(int value, int min, int max)
        {
            bool ret = false;

            if (value > min && value < max)
            {
                ret = true;
            }

            return ret;
        }
    }
}
