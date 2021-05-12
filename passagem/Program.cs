using System;

namespace passagem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool senha_errada = false;
            string senha_correta = "12345";
            string[] cadastro_passagem = new string[5];
            bool pa = false;
            string[] nome;
            nome = new string[5];
            string[] partida;
            partida = new string[5];
            string[] destino;
            destino = new string[5];
            string[] data;
            data = new string[5];
            int c = 0;

            do
            {
                Console.WriteLine("insira sua senha:");
                string senha = Console.ReadLine();

                if (senha == senha_correta)
                {
                    do
                    {
                        // senha_errada = false;
                        Console.WriteLine("use 1,2 e 0 para interagir com o menu");
                        Console.WriteLine(@$"Menu:
1- Cadastrar passagem
2- Listar passagem
0- Sair");
                        string menu = Console.ReadLine();
                        switch (menu)
                        {
                            case "1":
                                Console.WriteLine("você pode cadastrar até 5 passageiros");

                                do
                                {
                                    Console.WriteLine("deseja cadastrar algum voo? (s/n)");
                                    string parar = Console.ReadLine().ToLower().Substring(0, 1);
                                    if (parar == "s")
                                    {
                                        Console.WriteLine($"{c + 1}º passageiro\n");
                                        Console.WriteLine("Nome completo:");
                                        nome[c] = Console.ReadLine();
                                        
                                        Console.WriteLine("\npartida:");
                                        partida[c] = Console.ReadLine();
                                        
                                        Console.WriteLine("\ndestino:");
                                        destino[c] = Console.ReadLine();
                                        
                                        Console.WriteLine("\ndata do voo:");
                                        data[c] = Console.ReadLine();
                                        c++;
                                        pa = true;
                                    }
                                    else
                                    {
                                        pa = false;
                                    }

                                } while (pa == true);

                                break;
                            case "2":
                                // int a = 0;
                                for (var i = 0; i < c; i++)
                                {
                                    Console.WriteLine($@"{i + 1}º cadastro:

Nome Completo:
{nome[i]}

Partida:
{partida[i]} 

Destino:
{destino[i]} 

Data:
{data[i]} 

");
                                }




                                break;
                            case "0":
                                Console.WriteLine("tenha uma boa tarde e otima viagem!!");
                                pa = true;
                                break;
                            default:
                                break;
                        }
                    } while (pa == false);
                    senha_errada = true;
                }
                else
                {
                    Console.WriteLine("senha invalida, tente novamente");
                }
            } while (senha_errada == false);
        }
    }
}
