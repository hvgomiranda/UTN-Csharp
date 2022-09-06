namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta hugo = new Cuenta("Hugo Miranda Campos", 45000);

            hugo.Ingresar();
            hugo.Retirar();
            hugo.Mostrar();
        }
    }

    public class Cuenta
    {
        public string titular;
        public float cantidad;

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string getTitular()
        {
            return this.titular;
        }

        public float getCantidad()
        {
            return this.cantidad;
        }

        public void Mostrar()
        {
            Console.WriteLine("El titular de la cuenta es {0} y el dinero que figura en su cuenta es de {1} pesos", this.titular, this.cantidad);
        }

        public float Ingresar()
        {
            float nuevaCantidad;
            nuevaCantidad = (float)IO.askInteger(0, 9999999);
            this.cantidad += nuevaCantidad;
            Console.WriteLine($"El nuevo monto es {this.cantidad}");
            return this.cantidad;
        }

        public float Retirar()
        {
            float nuevaCantidad;
            nuevaCantidad = (float)IO.askInteger(0, 9999999);
            this.cantidad -= nuevaCantidad;
            Console.WriteLine($"El nuevo monto es {cantidad}");
            return this.cantidad;
        }
    }
}