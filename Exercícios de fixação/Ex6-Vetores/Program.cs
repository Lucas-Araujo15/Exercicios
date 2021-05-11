using System;

namespace Ex6_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.Write($"Digite o {i + 1}º nome: ");
                nomes[i] = Console.ReadLine().ToUpper();

            }

            int j = 0;
            bool repetir = true;
            bool confirmacao = true;

            do
            {
                Console.Write("Qual nome deseja verificar? ");
                string verificar = Console.ReadLine().ToUpper();
                repetir = true;
                j = 0;

                do
                {
                    if (verificar == nomes[j])
                    {
                        Console.WriteLine("\nO nome consta em nossas listas.\n");
                        Console.Write("Deseja pesquisar outro nome?(s/n) ");

                        if (Console.ReadLine() == "s")
                        {
                            repetir = false;
                            confirmacao = true;
                        }
                        else
                        {
                            repetir = false;
                            confirmacao = false;
                        }
                    }
                    else if (j == 9)
                    {
                        Console.WriteLine("\nO nome pesquisado não foi encontrado.\n");
                        Console.Write("Deseja pesquisar outro nome?(s/n) ");

                        if (Console.ReadLine() == "s")
                        {
                            repetir = false;
                            confirmacao = true;
                        }
                        else
                        {
                            repetir = false;
                            confirmacao = false;
                        }
                    }
                    j++;

                } while (repetir == true);
            } while (confirmacao == true);

        }
    }
}
