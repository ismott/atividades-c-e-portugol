using System;

namespace sistema_de_produtos
{
    class Program
    {

        static int TamanhoArray = 2;
        static string[] nome = new string[TamanhoArray];
        static float[] preco = new float[TamanhoArray];
        static bool Recadastro = false;
        static bool limitacao = false;
        static bool[] promocao_bool = new bool[TamanhoArray];
        static int c = 0;
        static int a = TamanhoArray;

        static void Main(string[] args)
        {
            do
            {
                do
                {
                    string Menuop = MostrarMenu();
                    if (limitacao == true)
                    {
                        Console.WriteLine("Você atingiu o limite maximo de cadastros");
                    }
                    switch (Menuop)
                    {
                        case "1":
                            do
                            {
                                if (c < TamanhoArray)
                                {
                                    CdastrarProduto();
                                    Console.WriteLine("deseja fazer mais algum cadastro? (s/n)");
                                    string parar = Console.ReadLine().ToLower().Substring(0, 1);

                                    if (parar == "n")
                                    {
                                        Recadastro = false;
                                    }
                                    else
                                    {
                                        Recadastro = true;
                                    }
                                }
                                else
                                {
                                    limitacao = true;
                                    Recadastro = false;
                                }

                            } while (Recadastro == true);
                            break;
                        case "2":
                            ListarProdutos();
                            break;
                        case "3":
                            Console.WriteLine("ok, obrigado pelo cadastro tenha um bom dia");
                            Recadastro = true;
                            break;
                        default:
                            break;
                    }
                } while (limitacao == true);
            } while (Recadastro == false);

        }

        static string MostrarMenu()
        {
            Console.WriteLine($@"
================================
|            Menu              |
================================
W    1- Cadastrar produtos     W
|                              |
Z    2- Lista de produtos      Z
|                              |
W    3- Sair                   W
================================");
            string menu = Console.ReadLine().ToLower().Substring(0, 1);
            return menu;
        }

        static void CdastrarProduto()
        {
            Console.WriteLine($"você só pode fazer até {TamanhoArray} cadastros");
            do
            {
                if (a > 0)
                {
                    Console.WriteLine($"você ainda pode fazer {a} cadastros");
                }
                else
                {
                    Console.WriteLine($"você não pode fazer mais cadastro");
                }
                Console.WriteLine($"{c + 1}º cadastro");
                Console.WriteLine("Nome do produto");
                nome[c] = Console.ReadLine();

                Console.WriteLine("Preço do produto");
                preco[c] = float.Parse(Console.ReadLine());

                Console.WriteLine("vai ter promoção? (sim/não)");
                string promocao = Console.ReadLine().ToLower().Substring(0, 1);
                if (promocao == "não")
                {
                    promocao_bool[c] = false;
                    Recadastro = false;
                }
                else
                {
                    promocao_bool[c] = true;
                    Recadastro = false;
                }
                c++;
                a--;


            } while (Recadastro == true);
        }

        static void ListarProdutos()
        {
            for (var i = 0; i < c; i++)
            {
                Console.WriteLine($@"{i + 1}º Cadastro:
Nome: 
{nome[i]} 

Preço: 
{preco[i]}

Promoção:
");
                if (promocao_bool[c] == true)
                {
                    Console.WriteLine($"seu produto tem promoção");
                }
                else
                {
                    Console.WriteLine("não foi adicionado uma promoção a esse produto");
                }
            }
        }
    }
}
