using System.Drawing;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            double numberPower2;
            double numberPower3;
            number = IO.askInteger(0, 9999999);
            numberPower2 = Math.Pow(number, 2);
            numberPower3 = Math.Pow(number, 3);
            Console.WriteLine("El cuadrado de {0} es {1} y su cubo es {2}", number, numberPower2, numberPower3);
        }
    }
}