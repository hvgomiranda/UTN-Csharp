using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
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

        public static bool ValidateChar(char value, char optionA, char optionB)
        {
            bool ret = false;

            if(value==optionA || value==optionB)
            {
                ret = true;
            }

            return ret;
        }

        public static bool ValidateAnswer(string message, char optionA, char optionB)
        {
            bool ret = false;
            char answer;

            Console.WriteLine("{0}, {1}/{2}", message, optionA, optionB);
            answer = Console.ReadKey().KeyChar;
            answer = char.ToLower(answer);
            optionA = char.ToLower(optionA);
            optionB = char.ToLower(optionB);

            while(!ValidateChar(answer, optionA, optionB))
            {
                Console.WriteLine("Letra erronea. {0}, {1}/{2}", message, optionA, optionB);
                answer = Console.ReadKey().KeyChar;
                answer = char.ToLower(answer);
                optionA = char.ToLower(optionA);
                optionB = char.ToLower(optionB);
            }

            if (answer == optionA || answer == optionB)
            {
                if (answer == optionA)
                {
                    ret = true;
                }
                else
                {
                    ret = false;
                }
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
    }
}
