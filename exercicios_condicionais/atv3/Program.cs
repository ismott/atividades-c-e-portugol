using System;

namespace atv3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual o nome do produto?");
            string nome = Console.ReadLine();
            
            Console.WriteLine("quantos produtos sera?");
            int quant = int.Parse(Console.ReadLine());
            
            Console.WriteLine("qual o preço de um produto?");
            float preco = int.Parse(Console.ReadLine());

            if (quant <= 5)
            {
                double total = quant * preco;
                double desconto = preco * 2 / 100;
                double total_pagar = total - desconto; 
                Console.WriteLine($"o total é de: {total}, mas você recebeu 2% de desconto, então pagara: {total_pagar}");
            }
            else
            {
                if (quant > 5 && quant <= 10)
                {
                    double total = quant * preco;
                    double desconto = preco * 3 / 100;
                    double total_pagar = total - desconto; 
                    Console.WriteLine($"o total é de: {total}, mas você recebeu 3% de desconto, então pagara: {total_pagar}");
                }
                else
                {
                    double total = quant * preco;
                    double desconto = preco * 5 / 100;
                    double total_pagar = total - desconto; 
                    Console.WriteLine($"o total é de: {total}, mas você recebeu 5% de desconto, então pagara: {total_pagar}");  
                }
            }
            
        }
    }
}
