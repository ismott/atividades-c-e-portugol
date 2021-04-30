using System;

namespace atv3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ola para que ganhe o aumento precisamos saber seu o salrio!");
            float salario = float.Parse(Console.ReadLine());

            if (salario < 500)
            {
                float aumento = salario * 30 / 100;
                Console.WriteLine("Parabéns vc recebeu um aumento de 30% 😀. Seu salario agora é: " + aumento + "$");
            }
            else
            {
                Console.WriteLine("com esse salario você não tem direito a aumento! 😞");
            }
        }
    }
}
