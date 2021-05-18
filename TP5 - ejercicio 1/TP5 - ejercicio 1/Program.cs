using System;

namespace TP5___ejercicio_1
{
    class Program
    {
        public static void funcion_invertir (int _)
        {
            int aux=0;
            if((_ < 0) || (_ == 0))
            {
                Console.WriteLine("El numero no se pude invertir \n");
            }
            else
            {
                Console.Write("El numero invertido es: "); 
                while(_ !=0)
                {
                    aux = _% 10;
                    Console.Write(aux);
                    _ = (_ / 10);
                }
            }
        }
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Trabajo Practino N° 5 - ejercicio 1 \n");
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            funcion_invertir(numero);

        }
    }
}
