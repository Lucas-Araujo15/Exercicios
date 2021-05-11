using System;

namespace Ex2_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            bool confirmacao = true;
            string[] combustiveis = new string[2] {"Gasolina", "Álcool"};
            
            do
            {

                Console.WriteLine(@$"Qual é o tipo de combustível?
(0) Gasolina
(1) Álcool");
                int inicio = int.Parse(Console.ReadLine());

                if (inicio == 0 || inicio == 1)
                {
                    confirmacao = true;
                    switch (combustiveis[inicio])
                    {
                        case "Gasolina":
                            Console.Write("Qual a quantidade em litros? ");
                            double qnt = double.Parse(Console.ReadLine());
                            Console.WriteLine($"O valor já com desconto é igual a {Posto1(qnt).ToString("N2")} reais");
                            break;
                        case "Álcool":
                            Console.Write("Qual a quantidade em litros? ");
                            qnt = double.Parse(Console.ReadLine());
                            Posto2(qnt);
                            Console.WriteLine($"O valor já com desconto é igual a {Posto2(qnt).ToString("N2")} reais");
                            break;
                    }
                }
                else
                {
                    confirmacao = false;
                    Console.WriteLine("Opção inválida. Favor, digite novamente!\n");
                }
            } while (confirmacao == false);
        }

        static double Posto1(double quantidade1)
        {

            double resultado1 = 0;

            if (quantidade1 <= 20)
            {
                resultado1 = quantidade1 * (5.3 - (5.3 * 0.04));

            }
            else if (quantidade1 > 20)
            {
                resultado1 = quantidade1 * (5.3 - (5.3 * 0.06));

            }
            return resultado1;
        }

        static double Posto2(double quantidade2)
        {
            double resultado2 = 0;

            if (quantidade2 <= 20)
            {
                resultado2 = quantidade2 * (4.9 - (4.9 * 0.03));

            }
            else if (quantidade2 > 20)
            {
                resultado2 = quantidade2 * (4.9 - (4.9 * 0.05));

            }
            return resultado2;
        }
    }
}
