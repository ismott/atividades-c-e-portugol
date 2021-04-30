using System;

namespace atv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eu sou um genio da lampada, e vou adivinhar sua idade. Coloque o ano em que naceu e o ano em que estamaos a seguir:\n");
            
            Console.WriteLine("você naceu em que ano?");
            int AnoNacimento = int.Parse(Console.ReadLine());
            Console.WriteLine("em que ano estamos?");
            int AnoAtual = int.Parse(Console.ReadLine());
            int IdadePessoa = -AnoNacimento + AnoAtual;
            if (IdadePessoa > 125)
            {
                Console.WriteLine("Acho que vc já morreu!! sintu muito😭. mas você é um fantasma👻 ou um esqueleto💀?🤔");
            }
            else
            {               
            int semana = IdadePessoa * 48;
            Console.WriteLine("sua idade é: " + IdadePessoa);
            Console.WriteLine("sua idade em semanas é: " + semana);
            }
            
            if (IdadePessoa >= 100 && IdadePessoa <= 122 )
            {
                Console.WriteLine("você é muito velho 👴, parabéns sua saude deve estar em otimas condições!!");
            }
            if (IdadePessoa > 122 && IdadePessoa <= 125)
            {
                Console.WriteLine("caramba acho que vc bateu o recorde de pesso viva por mais tempo no mundo!!😄 ");
            }

           
        }
    }
}
