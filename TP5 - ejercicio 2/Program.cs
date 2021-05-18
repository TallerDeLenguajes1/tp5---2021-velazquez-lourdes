using System;

namespace TP5___ejercicio_2

/*Construir un programa que sea una calculadora que permita al usuario
realizar las 4 operaciones básicas (Sumar, Restar, Multiplicar y Dividir) a partir de un
menú para seleccionar la opción a elegir y luego que le pida dos números y que
devuelva el resultado de la operación seleccionada. Además una vez que termine de
realizar la operación que le pregunte si desea realizar otro cálculo.
Utilizando la librería Math*/
{
    class Program
    {
        public static void OPERACION (double a, double b, string operac)
        {
            double resultado;

            if (operac == "suma")
            {
                resultado = a + b;
                Console.WriteLine("resultad: " + resultado);
            }
            else if (operac == "resta")
            {
                resultado = a - b;
                Console.WriteLine("resultad: " + resultado);
            }
            else if (operac == "multiplicacion")
            {
                resultado = a * b;
                Console.WriteLine("resultad: " + resultado);
            }
            else if (operac == "divicion")
            {
                resultado = a / b;
                Console.WriteLine("resultad: "+resultado);
            }
                else
            {
                Console.WriteLine("error");
            }
            
        }

        static void Main(string[] args)
        {
            string operacion;
            double A, B;
            Console.WriteLine("Trabajo Practico N° 5 - ejercici 2 \n");
            Console.WriteLine("Ingrese el tipo de operacon que quiere realizar \n");
            operacion = Console.ReadLine();
            Console.WriteLine("ingrese los numeros \n");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            OPERACION(A, B, operacion);
        }

}
}
