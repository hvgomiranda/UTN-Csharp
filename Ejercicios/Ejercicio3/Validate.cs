using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
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

        public static bool IsPrime(int value)
        {
            bool ret = true;

            for(int i=1; i<value; i++)
            {
                if(i!=1 && i!=value && value%i==0)
                {
                    ret = false;
                }
            }

            return ret;
        }
    }
}
