// See https://aka.ms/new-console-template for more information
using System;

namespace CalculadoraFisica
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Interfaz interfaz = new Interfaz(calculadora);
            interfaz.Ejecutar();
        }
    }


    public class Calculadora
    {
        public double CalcularDistancia(double velocidad, double tiempo)
        {
            return velocidad * tiempo;
        }

        public double CalcularVelocidad(double distancia, double tiempo)
        {
            return distancia / tiempo;
        }

        public double CalcularTiempo(double distancia, double velocidad)
        {
            return distancia / velocidad;
        }

        // Implementa los métodos restantes para MRUA
    }

    public class Interfaz
    {
        private Calculadora calculadora;

        public Interfaz(Calculadora calc)
        {
            calculadora = calc;
        }

        public void MostrarMenu()
        {
            Console.WriteLine("1. Calcular distancia (MRU)");
            Console.WriteLine("2. Calcular velocidad (MRU)");
            Console.WriteLine("3. Calcular tiempo (MRU)");
            // Agregar opciones restantes para MRUA
            Console.WriteLine("7. Terminar programa");
        }

        public void Ejecutar()
        {
            while (true)
            {
                MostrarMenu();
                Console.Write("Ingrese el número de la opción que desea: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingrese la velocidad (m/s): ");
                    double velocidad = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el tiempo (s): ");
                    double tiempo = double.Parse(Console.ReadLine());
                    double distancia = calculadora.CalcularDistancia(velocidad, tiempo);
                    Console.WriteLine($"La distancia es: {distancia} metros.");
                }
                else if (opcion == 2)
                {
                    // Implementa la funcionalidad para calcular la velocidad
                }
                else if (opcion == 3)
                {
                    // Implementa la funcionalidad para calcular el tiempo
                }
                // Agrega casos restantes para MRUA
                else if (opcion == 7)
                {
                    Console.WriteLine("¡Hasta luego!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                }
            }
        }
    }
}
