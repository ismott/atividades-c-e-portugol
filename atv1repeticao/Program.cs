using System;

namespace atv1repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escolha um numero de 1 a 10");
            int resposta = int.Parse(Console.ReadLine());
            
            bool respostacorreta = false;
            while (respostacorreta == false)
            {
                if (resposta >= 1 && resposta <= 10)
                {
                    Console.WriteLine("legal seu valor é: " + resposta);
                    respostacorreta = true;
                }
                else
                {
                    Console.WriteLine("esse valor é invalido, escolha um numero de 1 a 10!");
                    resposta = int.Parse(Console.ReadLine());                     
                } 
            }
        }
    }
}
