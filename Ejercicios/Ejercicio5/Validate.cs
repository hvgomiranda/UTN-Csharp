using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
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

        public static bool IsPerfect(int value)
        {
            bool ret = false;
            int accumulator = 0;

            for (int i = 1; i < value; i++)
            {
                if (value % i == 0)
                {
                    accumulator += i;
                }
            }

            if(accumulator == value)
            {
                ret = true;
            }

            return ret;
        }

        public static bool isCenter(int value)
        {
            bool ret = true;
            int accumulatorMin = 0;
            int accumulatorMax = 0;

            for (int i = 0; i < value; i++)
            {
                accumulatorMin += i;

                for (int j = i+1; j < value; j++)
                {
                    accumulatorMax += j;
                    if(accumulatorMax>accumulatorMin || (j==value && accumulatorMax<accumulatorMin))
                    {
                        ret = false;
                        break;
                    }
                }
            }

            return ret;
        }
    }
}
