using System;

namespace atv2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] QuantNumeros = new int[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"escreva o {i + 1}º");
                QuantNumeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(QuantNumeros);

               Console.WriteLine($"o menor é: {QuantNumeros[0]}"); 
               Console.WriteLine($"o maior é: {QuantNumeros[9]}"); 
            
        }
    }
}
