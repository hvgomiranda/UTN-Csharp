using Clase2.Prueba;
using IOFile = System.IO.File; //ALIAS
using Clase2.Ejercicios;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, promedio;
            string numeroStr;
            int numeroMayor = 0;
            int numeroMenor = 0;
            int acumulador = 0;
            bool success;
            bool primerNumero = true;

            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroStr = Console.ReadLine();
                success = int.TryParse(numeroStr, out numero);

                while(!(success && Validador.Validar(numero, -100, 100)))
                {
                    Console.WriteLine("Error. Ingrese un numero: ");
                    numeroStr = Console.ReadLine();
                    success = int.TryParse(numeroStr, out numero);
                }

                if(primerNumero)
                {
                    numeroMayor = numero;
                    numeroMenor = numero;
                    primerNumero = false;
                }
                else
                {
                    if(numero > numeroMayor)
                    {
                        numeroMayor = numero;
                    }
                    if(numero < numeroMenor)
                    {
                        numeroMenor = numero;
                    }
                }
                acumulador += numero;
            }

            promedio = acumulador / 10;

            Console.WriteLine("El mayor numero es {0}, el menor es {1} y el promedio es {2}", numeroMayor, numeroMenor, promedio);

            int numero1, numero2;
            string operacion;



        }
    }
}

/*
namespace
Es una agrupación lógica de clases
Estas clases se ordenarán para tener un código más prolijo y coherente

se puede usar using para referenciar a una clase sin especificar toda su ruta
se recomienda usar alias para que no se generen problemas de clases con nombres iguales

namespace y clases van en mayúscula y con camelCase
métodos con mayúscula, debe ser un verbo
variables comienzan en minúscula

public es accesible desde cualquier lugar
private solo es accesible dentro de la clase
protected solo es accesible dentro de la clase y de aquellas derivadas (heredadas) de ella
internal solo se puede acceder dentro del proyecto
si no se pone nada es público por defecto

static significa que el método no puede accederse desde una instancia de clase, solo de la clase

 */