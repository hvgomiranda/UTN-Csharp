namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = IO.askInteger(0, 9999999);

            for(int i = 0; i < number; i++)
            {
                if (Validate.isCenter(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}