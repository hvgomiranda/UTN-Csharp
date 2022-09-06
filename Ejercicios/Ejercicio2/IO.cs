using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class IO
    {
        public static int askInteger(int min, int max)
        {
            string numberStr;
            int number;
            bool success;
            Console.WriteLine("Ingrese un numero: ");
            numberStr = Console.ReadLine();
            success = int.TryParse(numberStr, out number);

            while (!(success && Validate.ValidateInt(number, min, max)))
            {
                //Console.WriteLine("Error. Ingrese un numero o 'cancel' si desea cancelar la operacion: ");
                Console.WriteLine("Error. Ingrese un numero: ");
                numberStr = Console.ReadLine();
                /*if(String.ToLower(numberStr) == "cancel")
                {
                    break;
                }*/
                success = int.TryParse(numberStr, out number);
            }

            return number;
        }
    }
}
