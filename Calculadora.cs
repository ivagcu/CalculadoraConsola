using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalculadoraConsola
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Introduce el primer número número");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número número");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\n" + "Selecciona la operación:" + "\n");

            Console.WriteLine("1) Suma");
            Console.WriteLine("2) Resta");
            Console.WriteLine("3) Multiplicacion");
            Console.WriteLine("4) División");
            Console.WriteLine("5) Comprobar si Num1 es < que Num2");
            Console.WriteLine("6) Comprobar si Num1 es > que Num2");
            Console.WriteLine("7) Comprobar si Num1 es = a Num2" + "\n");

            switch (Console.Read())
            {
                case '1':
                    Suma(num1, num2);
                    break;
                case '2':
                    Resta(num1, num2);
                    break;
                case '3':
                    Multiplicacion(num1, num2);
                    break;
                case '4':
                    Division(num1, num2);
                    break;
                case '5':
                    MenorQue(num1, num2);
                    break;
                case '6':
                    MayorQue(num1, num2);
                    break;
                case '7':
                    Igual(num1, num2);
                    break;
            }
        }
            

        static double Suma(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("El resultado de la operación es: " + result);
            return result;
        }

        static double Resta(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("El resultado de la operación es: " + result);
            return result;
        }

        static double Multiplicacion(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine("El resultado de la operación es: " + result);
            return result;
        }

        static double Division(double n1, double n2)
        {
            double result = n1 / n2;
            Console.WriteLine("El resultado de la operación es: " + result);
            return result;
        }

        static Boolean MenorQue(double n1, double n2)
        {
            Boolean result = n1 < n2;
            Console.WriteLine("El resultado de la operación es: " + result);
            return result;
        }

        static Boolean MayorQue(double n1, double n2)
        {
            Boolean result = n1 > n2;
            Console.WriteLine("El resultado de la operación es: " + result);
            return result;
        }

        static Boolean Igual(double n1, double n2)
        {
            Boolean result = n1 == n2;
            Console.WriteLine("El resultado de la operación es: " + result);
            return result;
        }
    }
}
