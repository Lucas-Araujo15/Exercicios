using System;

namespace Ex3_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o nome do produto? ");
            string nome = Console.ReadLine();

            Console.Write($"Qual a quantidade adquirida de {nome}? ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write($"Qual o valor unitário de {nome}? ");
            double valor = double.Parse(Console.ReadLine());

            double total = quantidade * valor;

            if (quantidade <= 5)
            {
                double resultado = total - (total * 0.02);
                Console.WriteLine($"O total a pagar com desconto é igual a R${resultado.ToString("F")}, e sem desconto igual a {total}");

            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                double resultado = total - (total * 0.03);
                Console.WriteLine($"O total a pagar com desconto é igual a R${resultado.ToString("F")}, e sem desconto igual a {total}");
            }
            else
            {
                double resultado = total - (total * 0.05);
                Console.WriteLine($"O total a pagar com desconto é igual a R${resultado.ToString("F")}, e sem desconto igual a R${total}");
            }
        }
    }
}
