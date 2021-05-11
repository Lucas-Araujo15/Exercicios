using System;

namespace Ex7_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [15];

            for (int i = 0; i <= 14; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for (int i = 14; i >= 0; i--)
            {
                Console.WriteLine (numeros[i]);
            }
        }
    }
}
