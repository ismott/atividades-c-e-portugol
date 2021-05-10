using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("em que ano você naceu?");
            int ano_nacimento = int.Parse(Console.ReadLine());
            Console.WriteLine("em que ano estamos?");
            int ano_atual = int.Parse(Console.ReadLine());

            int idade = ano_atual - ano_nacimento;

            if (idade >= 16)
            {
                Console.WriteLine("parabéns agora você já pode desgraçar o pais");
            }
            else
            {
                Console.WriteLine("felizmente você ainda não pode nos ferrar");
            }
        }
    }
}
