using System;

namespace desafio_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (var i = 0; i < 10; i++)
            // {   
                
            //     int cont = i;
            //     int contador = 1 ;
            //     int co = contador - cont;
            //     // int c = co + contador; 
            //     Console.WriteLine(co);
            // }
            
            int penultimoElemento = 0;
            int ultimoElemento = 1;

            Console.WriteLine(penultimoElemento);
            Console.WriteLine(ultimoElemento);

            for (int elemento = 0; elemento < 500;)
            {
                elemento = penultimoElemento + ultimoElemento;
                Console.WriteLine(elemento);

                penultimoElemento = ultimoElemento;
                ultimoElemento = elemento;
            }
        }
    }
}
