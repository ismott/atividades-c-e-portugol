using System;

namespace for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] embalagens = null;

            Console.WriteLine("quantas embalagens de pão de queijo tem na pratileira?");
            int quantidadeEmbalagens = int.Parse(Console.ReadLine());
            embalagens = new int [quantidadeEmbalagens];

            int c = 0;
            foreach (var item in embalagens)
            {
                Console.WriteLine($"quantos pães de queijo tem na {c + 1}º embalagem");
                embalagens[c] = int.Parse(Console.ReadLine());
                c++;
            }
            int a = 1;
            foreach (var item in embalagens)
            {
                Console.WriteLine($"Na {a}º embalagens a: {item}");
                a++; 
            }
        }
    }
}
