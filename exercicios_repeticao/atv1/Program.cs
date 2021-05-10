using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var cont = 0; cont < 10; cont++)
            {   
                Console.WriteLine($"tabuada do {cont + 1}:");             
                for (var i = 0; i <= 10; i++)
                {
                       
                        Console.WriteLine($"{i}*{i}: {i * (1 + cont)} ");
                    // if (cont >= 1)
                    // {
                    // }
                    // else
                    // {
                    //     Console.WriteLine(@$" tabuada do 1: {i * (1 + cont)}");                        
                    // }
                }
            }
            
        }
    }
}
