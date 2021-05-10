using System;

namespace atv2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = new string[15];
            
            Console.WriteLine("escreva 15 numeros:");

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"escreva o {i + 1}º ");
                numeros[i] = (Console.ReadLine());
            }
           
            Array.Reverse(numeros);
                foreach (var item in numeros)
                {
                   Console.WriteLine(item); 
                }
                
            // int c = 3;
            // foreach (var item in numeros)
            // {    
            //     Console.WriteLine(numeros[3]);
            //     c++;
            // }
            

            // for (var i = 5; i > 0; i--)
            // {
            //     Console.WriteLine(i);
            // }
        }
    }
}
