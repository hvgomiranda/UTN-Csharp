using System;

namespace ConsoleApp1
{
    internal class Program //clase = agrupación de variables y métodos
    {
        static void Main(string[] args) //método main = C
        {
            /*
             Declarar y asignar una variable del tipo string}
            calcular su longitud
            si es mayor a 5 mostrar es "es mayor a 5"
            de lo contrario mostrar "es menor a 5"
            si es igual a 5 "es igual a 5"
             */

            string name;
            string numberStr;
            int number;
            bool isOk;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            //Console.Beep(3000, 2000);
            Console.Write("Ingrese una cadena de caracteres: ");
            name = Console.ReadLine();

            Console.Write("Ingrese el numero para medir la cantidad de caracteres: ");
            numberStr = Console.ReadLine();
            isOk = int.TryParse(numberStr, out number);
            if(isOk)
            {
                
            }
            else
            {

            }


            int len = name.Length;

            Console.WriteLine("El nombre es {0} y el tamanio del nombre es {1}", name, len);

            if(len>number)
            {
                Console.WriteLine("Es mayor a {0}", number);
            }
            else if(len<number)
            {
                Console.WriteLine("Es menor a {0}", number);
            }
            else
            {
                Console.WriteLine("Es igual a {0}", number);
            }

            /*string name = "Hugo";
            int age = 29;

            Console.WriteLine("Hello, {0}! You're {1} years old.", name, age);*/
        }
    }
}


/*una clase es un lugar donde vamos a agrupar variables y métodos. Están ligadas a la misma entidad.
Cuando una función está asociada a un objeto se llama método.

Si tenemos una clase usuario, la podemos instanciar en diferentes personas (mario, federico).
Es la singularidad de la clase usuario.
Static se relaciona con la clase y no con la instancia.



 */