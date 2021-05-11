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
                Console.WriteLine($"escreva o {i + 1}º nome dessa lista de dez pessoas");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("escreva o nome de uma pessoa aleatoria e verificarei se esta na lista");
            string nome_aleatorio = Console.ReadLine();
            bool encontrado = false;

            foreach (var item in nomes)
            {
                if (item == nome_aleatorio)
                {
                    encontrado = true;
                }
            }
                if (encontrado)
                {
                    Console.WriteLine("Achei o nome da pessoa esta na lista!!!"); 
                }
                else
                {
                    Console.WriteLine("Não ta na lista pode expulsar");
                }
        }
    }
}
