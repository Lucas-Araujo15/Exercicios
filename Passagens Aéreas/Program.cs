using System;

namespace Passagens_Aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validacao;
            bool repetir = false;
            bool voltarMenu = false;
            string[] passageiros = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            do
            {
                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();

                if (senha == "12345")
                {
                    validacao = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Senha incorreta.");
                    Console.ResetColor();
                    validacao = true;
                }
            } while (validacao);

            int i = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"
_________________________            
|_________MENU__________|            
|                       |
|(1) Cadastrar passagens|
|(2) Listar passagens   |
|(0) Sair               |
|_______________________|");
                Console.ResetColor();
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                    Console.Clear();
                        do
                        {
                            if (i <= 4)
                            {
                                Console.Write("\nDigite o nome do passageiro: ");
                                passageiros[i] = Console.ReadLine();

                                Console.Write("Digite sua origem: ");
                                origem[i] = Console.ReadLine();

                                Console.Write("Digite o destino: ");
                                destino[i] = Console.ReadLine();

                                Console.Write("Digite a data do vôo (DD/MM/AA): ");
                                data[i] = Console.ReadLine();

                                Console.WriteLine("Passageiro cadastrado com sucesso!");

                                Console.Write("Gostaria de cadastrar outro passageiro (s/n)? ");
                                string confirmacao = Console.ReadLine();

                                if (confirmacao == "s")
                                {
                                    Console.Clear();
                                    repetir = true;
                                    i++;
                                }
                                else
                                {
                                    Console.Clear();
                                    voltarMenu = true;
                                    repetir = false;
                                    i++;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("O limite de cadastros já foi alcançado!");
                                Console.ResetColor();
                                repetir = false;
                                voltarMenu = true;
                            }

                        } while (repetir);
                        break;
                    case 2:
                    Console.Clear();
                        if (i == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nenhum passageiro foi cadastrado.");
                            Console.ResetColor();
                        }
                        else
                        {
                            for (var j = 0; j <= i - 1; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n");
                                Console.WriteLine($@"
______________________________
|______{passageiros[j]}______|
|Destino    |{destino[j]}    |
|Origem     |{origem[j]}     |
|Data do vôo|{data[j]}       |
------------------------------");
                            }
                            Console.ResetColor();
                        }
                        voltarMenu = true;
                        break;
                    case 0:
                    Console.Clear();
                        Console.WriteLine("Obrigado e volte sempre!");
                        voltarMenu = false;
                        break;
                    default:
                    Console.Clear();
                        Console.WriteLine("Escolha alguma das opções apresentadas.");
                        voltarMenu = true;
                        break;
                }
            } while (voltarMenu);
        }
    }
}
