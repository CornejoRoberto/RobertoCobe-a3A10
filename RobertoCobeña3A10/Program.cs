using System;

namespace RobertoCobeña3A10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, suma = 0, f, con1 = 0, factorial = 1, k;
                    do{
            Console.WriteLine("Programa para calcular sumas y factoriales");
            Console.WriteLine("1)Salir");
            Console.WriteLine("2)Sumatorio");
            Console.WriteLine("3)Factorial");
            Console.Write("Seleccione su opción:");
            num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("Operación Finalizada");
            }
            else
                if (num1 == 2)
            {
                Console.Write("Ingrese su número para aplicar el sumatorio:");
                f = int.Parse(Console.ReadLine());
                for (int i = 1; i <= f; i++)
                {
                    suma = (suma + i); 
                    Console.WriteLine(suma);
                }
            }
            else
                if (num1 == 3)
            {
                Console.Write("ingrese un número para aplicar el factorial:");
                k = int.Parse(Console.ReadLine());
                for (int i = 1; i <= k; i++)
                {
                    con1 = con1 + 1;
                    factorial = factorial * con1;
                    Console.WriteLine("El factorial de " + k + " "+ "es:" + factorial);                  
                }
            }
            } while (num1 != 1);
    }
    }
} 