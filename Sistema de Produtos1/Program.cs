using System;
using System.Threading;


namespace Sistema_de_Produtos1
{
    class Program
    {

        static int tamanho = 2;
        static int tamanho2 = 2;
        static string[] nomesReserva = new string[tamanho2];
        static float[] precosReserva = new float[tamanho2];
        static bool[] promocaoReserva = new bool[tamanho2];
        static string[] nomes = new string[tamanho];
        static float[] precos = new float[tamanho];
        static bool[] promocao = new bool[tamanho];

        static int i = 0;


        static void Main(string[] args)
        {
            bool resposta = false;
            string validacao;
            bool repeticao = false;

            Console.WriteLine($@"
                                 Seja bem vindo!");
            Thread.Sleep(2000);
            do
            {

                MostrarMenu();

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (i == nomes.Length)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O limite de cadastros já foi alcançado.");
                            Console.Write("Gostaria de expandir o espaço? (s/n) ");
                            Console.ResetColor();
                            string expandir = Console.ReadLine();

                            if (expandir == "s")
                            {
                                Console.Write("Quantos produtos a mais você deseja cadastrar? ");
                                int acrescimo = int.Parse(Console.ReadLine());
                                tamanho = tamanho + acrescimo;
                                repeticao = true;

                                Aumentar(tamanho);

                            }
                        }
                        else
                        {
                            do
                            {
                                Cadastrar();

                                Console.Write("\nDeseja cadastrar outro produto? ");
                                validacao = Console.ReadLine().ToUpper();


                                if (validacao == "S")
                                {
                                    if (i == nomes.Length-1)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("O limite de cadastros já foi alcançado.");
                                        Thread.Sleep(3000);
                                        Console.ResetColor();
                                        repeticao = true;
                                        resposta = false;
                                        i++;
                                    }
                                    else
                                    {
                                        resposta = true;
                                        i++;
                                    }

                                }
                                else
                                {
                                    resposta = false;
                                    repeticao = true;
                                    i++;
                                }
                            } while (resposta);
                        }

                        break;
                    case "2":

                        int editar;
                        if (i == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNenhum produto foi cadastrado");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            repeticao = true;
                        }
                        else
                        {
                            do
                            {
                                Listar();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($@"
                 ======================================
                 |     Pressione 0 para SAIR  -->     |                     
                 ======================================");
                                Console.ResetColor();

                                editar = int.Parse(Console.ReadLine());
                                if (editar != 0)
                                {
                                    Console.Clear();
                                    int k = i;
                                    i = editar - 1;
                                    Cadastrar();
                                    i = k;
                                }

                            } while (editar != 0);
                        }
                        break;
                    case "0":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Salvando informações...");
                        repeticao = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Escolha uma das opções apresentadas");
                        Console.ResetColor();
                        break;
                }


            } while (repeticao);
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"
                         Cadastros: {i}/{tamanho}
                        ==================================
                        |             MENU               |
                        |      O que deseja fazer?       |
                        |================================|
                        |(1) Cadastrar produto -->       |
                        |================================|
                        |(2) Listar produtos -->         |
                        |================================|
                        |(0) Sair -->                    |
                        ==================================");
            Console.ResetColor();
        }

        static void Cadastrar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine($@"
----------------------------------------");
            Console.Write("Qual o nome do produto? ");
            string name = Console.ReadLine().ToUpper();
            nomes[i] = name;
            nomesReserva[i] = name;

            Console.WriteLine($@"
----------------------------------------");
            Console.Write($"Qual o preco de {nomes[i]}? ");
            float price = float.Parse(Console.ReadLine());
            precos[i] = price;
            precosReserva[i] = price;

            Console.WriteLine($@"
----------------------------------------");
            Console.Write($"{nomes[i]} está em promoção? (s/n) ");
            string ternario = Console.ReadLine().ToUpper();
            Console.WriteLine($@"
-----------------------------------------");
            promocao[i] = ternario == "s" ? true : false;
            promocaoReserva[i] = ternario == "s" ? true : false;

            Console.ResetColor();

        }

        static void Listar()
        {
            Console.Clear();
            int j;
            for (j = 0; j <= i - 1; j++)
            {
                string promo = promocao[j] == true ? "Aplicada" : "Não aplicada";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n");
                Console.WriteLine($@"
                ==========================================
                Nome     | {nomes[j]}
                ==========================================
                Preço    | R${precos[j]}
                ==========================================
                Promoção | {promo}
                ==========================================
                           Editar produto {j + 1}
                             Pressione {j + 1}
                ==========================================");
                Console.ResetColor();
            }
        }

        static void Aumentar(int espaco)
        {

            Array.Resize(ref nomes, espaco );
            Array.Resize(ref precos, espaco );
            Array.Resize(ref promocao, espaco );

            for (int w = 0; w <= nomesReserva.Length-1; w++)
            {
                nomes[w] = nomesReserva[w];
                precos[w] = precosReserva[w];
                promocao[w] = promocaoReserva[w];
            }

            Array.Resize(ref nomesReserva, espaco );
            Array.Resize(ref precosReserva, espaco );
            Array.Resize(ref promocaoReserva, espaco );

            for (int y = 0; y <= nomes.Length-1; y++)
            {
                nomesReserva[y] = nomes[y];
                precosReserva[y] = precos[y];
                promocaoReserva[y] = promocao[y];
            }
        }
    }
}
