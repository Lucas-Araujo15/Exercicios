using System;

namespace Ex4_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [10];

            for (int i = 0; i <= 9; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros [i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);
            
            Console.WriteLine($"O menor número digitado é {numeros[0]}");
            Console.WriteLine($"O maior número digitado é {numeros[9]}");
        }
    }
}
