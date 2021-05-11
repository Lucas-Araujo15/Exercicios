using System;

namespace Ex5_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADA DE 1 A 10\n");
            for (int i = 1; i <= 10; i++){
                Console.WriteLine($"\nTabuada do {i}:");
                for(int j = 1; j <= 10; j++){
                    int multi = i * j;
                    Console.WriteLine($"{i} * {j} = {multi}");
                }
            }
        }
    }
}
