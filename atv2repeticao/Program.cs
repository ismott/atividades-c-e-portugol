using System;

namespace atv2repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool senha_nome = true;
            do
            {
                Console.WriteLine("coloque seu nome aqui:");
                string nome = Console.ReadLine();
                Console.WriteLine("coloque seu senha aqui:");
                string senha = Console.ReadLine(); 

                if (nome == senha)
                {
                    Console.WriteLine("senha INVALIDA! lembre-se sua senha não pode ser igual ao nome, escolha uma nova senha:");
                    senha = Console.ReadLine();
                    senha_nome = false; 
                }
                else
                {
                    Console.WriteLine("parabéns cadastro concluido com exito");                    
                }
            } while (senha_nome == false);
        }
    }
}
