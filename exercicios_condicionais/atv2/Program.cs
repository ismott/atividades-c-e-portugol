using System;

namespace atv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual tipo de conbustivel vai querer? use A para álcool e G para gasolina");
            string tipo_combustivel = Console.ReadLine().ToUpper();
            
            Console.WriteLine("e quantos litros você gostaria?");
            float quant_litros = float.Parse(Console.ReadLine());

            switch (tipo_combustivel)
            {
                case "A":
                    if (quant_litros <= 20)
                    {
                        double desconto = ((4.90 * quant_litros) * 3 / 100 );
                        Console.WriteLine($"você ganhou um disconto de 3%, o preço a pagar é {desconto}");
                    }
                    else
                    {
                        double desconto = ((4.90 * quant_litros) * 5 / 100 );
                        Console.WriteLine($"você ganhou um disconto de 5%, o preço a pagar é {desconto}");
                    }
                    break;
                case "G":
                    if (quant_litros <= 20)
                    {
                        double desconto = ((5.30 * quant_litros) * 4 / 100 );
                        Console.WriteLine($"você ganhou um disconto de 4%, o preço a pagar é {desconto}");
                    }
                    else
                    {
                        double desconto = ((5.30 * quant_litros) * 6 / 100 );
                        Console.WriteLine($"você ganhou um disconto de 6%, o preço a pagar é {desconto}");
                    }
                    break;
                default:
                    break;
            }
            
        }

        // static double desconto_alcool()
        // {

        // }
    }
}
