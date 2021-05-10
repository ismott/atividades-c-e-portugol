using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"escreva o {i + 1}º nome pessoas dessa lista de dez pessoas");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("escreva o nome de uma pessoa aleatoria e verificarei se esta na lista");
            string nome_aleatorio = Console.ReadLine();

            foreach (var item in nomes)
            {
                if (item == nome_aleatorio)
                {
                    Console.WriteLine("Achei o nome da pessoa esta na lista sim!!!");
                    
                }
                else
                {
                    Console.WriteLine("pode expulsar esse ai não ta na lista");
                }
            }
        }
    }
}
