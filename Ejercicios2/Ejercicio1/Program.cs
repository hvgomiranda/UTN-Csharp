namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            do
            {
                Console.Clear();
                number += IO.askIntegerNoLimits();
                Console.WriteLine("La suma es {0}", number);

            } while (Validate.ValidateAnswer("Desea continuar?", 's', 'n'));
        }
    }
}