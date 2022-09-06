namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Estudiante
    {
        private string _apellido;
        private string _nombre;
        private string _legajo;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static Random _random;

        public Estudiante(string apellido, string nombre, string legajo)
        {
            _apellido = apellido;
            _nombre = nombre;
            _legajo = legajo;
        }

        static Estudiante()
        {
            _random = new Random();

        }

    }
}