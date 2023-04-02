using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {

                // Pedir al usuario que ingrese el primer número
                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Pedir al usuario que ingrese el segundo número
                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Pedir al usuario que ingrese la operación a realizar
                Console.Write("Ingrese la operación a realizar (+, -, *, /): ");
                string operacion = Console.ReadLine();

                double resultado = 0;

                // Realizar la operación seleccionada
                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Operación inválida.");
                        break;
                }

                // Imprimir el resultado en la consola
                Console.WriteLine("El resultado es: " + resultado);

                // Preguntar al usuario si desea continuar o salir del programa
                Console.Write("¿Desea realizar otro cálculo? (s/n): ");
                string respuesta = Console.ReadLine();


                if (respuesta.ToLower() == "n")
                {
                    continuar = false;
                }
            }

            Console.WriteLine("Fin del programa.");
            Console.ReadKey();
        }
    }
}
