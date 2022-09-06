namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter=0;
            number = IO.askInteger(0, 9999999);

            Console.WriteLine("Los siguientes numeros del 1 al {0} son primos: ", number);

            for(int i = 2; i <= number; i++)
            {

                if(Validate.IsPrime(i))
                {
                    Console.Write("{0} ", i);
                    counter++;
                }

                if(counter==0)
                {
                    Console.WriteLine("\nNo hay numeros primos para mostrar");
                }
            }
        }
    }
}