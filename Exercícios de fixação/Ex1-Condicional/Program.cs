using System;

namespace Ex1_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o ano de seu nascimento: ");
            int idade = int.Parse(Console.ReadLine());

            int atual = DateTime.Now.Year;

            int operacao = atual - idade;

            if (operacao > 16)
            {
                if (operacao > 18)
                {
                    Console.WriteLine("O seu voto é obrigatório.");
                }else{
                    Console.WriteLine("O seu voto é opcional.");
                }
            }else{
                Console.WriteLine("O seu voto ainda não é permitido.");
            }
            
        }
    }
}
