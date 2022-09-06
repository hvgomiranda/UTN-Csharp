namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sin constructor
            /*Moto moto = new Moto();
            moto.cilindrada = 650;
            moto.marca = "Honda";
            moto.modelo = "CBR";
            moto.patente = "AAD236";*/

            Moto moto = new Moto("Yamaha", "R6", "RDF156", 600);

            Console.WriteLine($"Moto {moto.marca}");

            moto.TocarBocina();

            Moto.LlenarTanque(moto);
        }
    }

    public class Moto
    {
        public string marca;
        public string modelo;
        public string patente;
        public int cilindrada;
        public int combustible;

        public Moto(string marca, string modelo, string patente, int cilindrada)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente;
            this.cilindrada = cilindrada;
            this.combustible = 1;
        }

        public void TocarBocina()
        {
            Console.WriteLine("Beep beep {0}", this.patente);
        }

        static public void LlenarTanque(Moto moto)
        {
            moto.combustible = 100;
            Console.WriteLine("Tanque full, acelera {0}", moto.patente);
        }
    }

    public class Persona
    {
        public string nombre;
        private int _dni; //se pone privado para que no se pueda modificar desde la instancia

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            _dni = dni;
        }

        public int getDni()
        {
            return _dni;
        }

        public void setDni(int dni)
        {
            _dni = dni;
        }
    }
}

/*
 
Un paradigma es un modelo de cómo resolver problemas

Los pilares del paradigma de la programación orientada a objetos son

encapsulación


abstracción
La habilidad de abordar un concepto dejando de lado los demás detalles

herencia


polimorfismo


¿Qué es una clase?
Una clase es una descripción de un conjunto de objetos que comparten 
los mismos atributos, métodos, relaciones y semántica en un determinado contexto.

Clases:
atributos (variables)
métodos (funciones)

Un objeto es una instancia de una clase
Es la manifestación concreta de una clase

Todas las clases tienen un constructor. Para instanciar una clase se usa el constructor.
El constructor es un método especial que se usa por única vez cuando se crea el objeto.

Los objetos solo son los mismos si su referencia en la memoria es igual

Los objetos pueden comunicarse entre sí, no es necesario que estén emparentados.



 */