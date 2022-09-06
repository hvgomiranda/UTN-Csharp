namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = IO.askInteger(0, 99999999);

            for(int i = 1; i < number; i++)
            {
                if(Validate.IsPerfect(i))
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}