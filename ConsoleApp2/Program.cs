using System;

namespace Calculadora
{
    class Program
    {

        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("..........-CALCULADORA- -•*.•.......");
                Console.WriteLine("Introduzca el primer número:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduzca el segundo número:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1 - Sumar\n2- Resta\n3-Multiplicar\n4-Dividir\n5-Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nEl resultado de la suma es:\n");
                        Console.WriteLine(suma(a, b));
                        break;
                    case 2:
                        Console.WriteLine("\nEl resultado de la resta es:\n");
                        Console.WriteLine(resta(a, b));
                        break;
                    case 3:
                        Console.WriteLine("\nEl resultado de la `multiplicacion es:\n");
                        Console.WriteLine(multiplicacion(a, b));
                        break;
                    case 4:
                        Console.WriteLine("\nEl resultado de la division es:\n");
                        Console.WriteLine(division(a, b));
                        break;
                    case 5:
                        (continuar) = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.holaaa");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static double division(double a, double b)
        {
            return a / b;
        }

        private static double multiplicacion(double a, double b)
        {
            return a * b;
        }

        private static double resta(double a, double b)
        {
            return a - b;
        }

        private static double suma(double a, double b)
        {
            return a + b;
        }
    }
}