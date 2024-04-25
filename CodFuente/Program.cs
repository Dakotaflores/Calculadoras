// See https://aka.ms/new-console-template for more information
/*using System;

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
    }*/

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bienvenido a la Calculadora Física");
            Console.WriteLine("Seleccione el tipo de cálculo:");
            Console.WriteLine("1. Movimiento Rectilíneo Uniforme (MRU)");
            Console.WriteLine("2. Movimiento Rectilíneo Uniformemente Acelerado (MRUA)");
            Console.WriteLine("3. Salir");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                CalcularMRU();
            }
            else if (opcion == 2)
            {
                CalcularMRUA();
            }
            else if (opcion == 3)
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

    static void CalcularMRU()
    {
        Console.WriteLine("Ingrese los valores para el cálculo de MRU:");
        Console.Write("Velocidad (m/s): ");
        double velocidad = double.Parse(Console.ReadLine());
        Console.Write("Tiempo (s): ");
        double tiempo = double.Parse(Console.ReadLine());

        double distancia = velocidad * tiempo;
        double nuevaVelocidad = distancia / tiempo;
        double nuevoTiempo = distancia / nuevaVelocidad;

        Console.WriteLine($"Distancia (d = v * t): {distancia} metros");
        Console.WriteLine($"Velocidad (v = d / t): {nuevaVelocidad} m/s");
        Console.WriteLine($"Tiempo (t = d / v): {nuevoTiempo} segundos");
    }

    static void CalcularMRUA()
    {
        Console.WriteLine("Ingrese los valores para el cálculo de MRUA:");
        Console.Write("Posición inicial (m): ");
        double posicionInicial = double.Parse(Console.ReadLine());
        Console.Write("Velocidad inicial (m/s): ");
        double velocidadInicial = double.Parse(Console.ReadLine());
        Console.Write("Aceleración (m/s^2): ");
        double aceleracion = double.Parse(Console.ReadLine());
        Console.Write("Tiempo (s): ");
        double tiempo = double.Parse(Console.ReadLine());

        double posicionFinal = posicionInicial + velocidadInicial * tiempo + 0.5 * aceleracion * Math.Pow(tiempo, 2);
        double nuevaVelocidad = velocidadInicial + aceleracion * tiempo;
        double nuevoTiempo = (nuevaVelocidad - velocidadInicial) / aceleracion;

        Console.WriteLine($"Posición final (x = x0 + v0 * t + 0.5 * a * t^2): {posicionFinal} metros");
        Console.WriteLine($"Velocidad final (v = v0 + a * t): {nuevaVelocidad} m/s");
        Console.WriteLine($"Tiempo (t = (v - v0) / a): {nuevoTiempo} segundos");
    }
}
