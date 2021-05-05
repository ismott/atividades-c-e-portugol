using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("qual a sua idade nadador?");
            // int idade_nadador = int.Parse(Console.ReadLine());

            // if (idade_nadador >= 5 && idade_nadador <= 7)
            // {
            //     Console.WriteLine("você pertence a sala infantil A");
            // }
            // else
            // {
            //     if (idade_nadador >= 8 && idade_nadador <= 10)
            //     {
            //         Console.WriteLine("você pertence a sala infantil B");
            //     }
            //     else
            //     {
            //         if (idade_nadador >= 14 && idade_nadador <= 17)
            //         {
            //             Console.WriteLine("você pertence a sala juvenil A");
            //         }
            //         else
            //         {
            //             Console.WriteLine("você pertence a sala juvenil B");
            //         }
            //     }
            // }

            // -------------------------------------------------------------------------------------------------------------------------------------------------------------
            
            bool contador = false;
            int idn;
            do{
            Console.WriteLine("qual a sua idade?");
            int idn = int.Parse(Console.ReadLine());
            }
            
            while (contador == false);
            {
                if (idn >= 5 && idn <=7){
                    Console.WriteLine("Você pertence a sala infantil A");
                    contador == true
                }
                else{
                    if (idn >= 8 && idn <=10){
                    Console.WriteLine("Você pertence a sala infantil B");
                    contador == true
                    }
                    else{
                        if (idn >=14 && idn <= 17){
                            Console.WriteLine("Você pertence a sala juvenil A");
                            contador == true
                        }
                    }
                }
            }

        }
    }
}
