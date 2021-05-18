using System;

namespace TP5___ejercicio_3
/*jercicio 3. Mejorando la Calculadora. Solicite al usuario un número y muestre por
pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.
Luego de esto, solicite dos números al usuario y determine:
● El Máximo entre los dos números
● El Mínimo entre los dos números*/
{
    class Program
    {
        public static void OPERACION(float a)
        {
            float valor_abs, cuadrado, raiz, seno, cose, parte_entera;

            valor_abs = Math.Abs(a);
            Console.WriteLine("Valor absoluto:  " + valor_abs);
            cuadrado = (float)Math.Pow(a, 2);
            Console.WriteLine("Cuadrado  " + cuadrado);
            raiz =(float) Math.Sqrt(a);
            Console.WriteLine("raiz:  " + raiz);
            seno = (float)Math.Sin(a);
            Console.WriteLine("seno:  " + seno);
            cose = (float)Math.Cos(a);
            Console.WriteLine("coseno:  " + cose);
            parte_entera =(float) Math.Truncate(a);
            Console.WriteLine("parte entera:  " + parte_entera);
           

        }

        public static void OPERACION_2( float b, float c)
        {
            float max, min;
            max = Math.Max(b, c);
            Console.WriteLine("MAXIMO:  " + max);
            min = Math.Min(b, c);
            Console.WriteLine("MINIMO: " + min);
        }
        static void Main(string[] args)
        {
           float A, B, C;
            Console.WriteLine("Trabajo Practico N° 5 - ejercici 2 \n");
            Console.WriteLine("ingrese un numeros \n");
            A = float.Parse(Console.ReadLine());
            OPERACION(A);
            Console.WriteLine("ingrese los numeros \n");
            C = float.Parse(Console.ReadLine());
            B = float.Parse(Console.ReadLine());
            OPERACION_2(B, C);
        }
    }
}
