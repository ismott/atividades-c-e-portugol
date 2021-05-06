using System;

namespace desafio_tabela
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] produtos;
            Console.WriteLine("quantos produtos gostaria de cadastrar?");
            int quantidadesProdutos = int.Parse(Console.ReadLine());
            produtos = new int[quantidadesProdutos];

            string[] nomeProdutos;
            nomeProdutos = new string[quantidadesProdutos];
            
            for (var i = 0; i < quantidadesProdutos; i++)
            {
                Console.WriteLine($"qual o nome do {i + 1}º produto");
                nomeProdutos[i] = Console.ReadLine();    
            }

            float[] valorProduto;
            valorProduto = new float[quantidadesProdutos];
            for (var i = 0; i < quantidadesProdutos; i++)
            {
                Console.WriteLine($"quato custara o {i + 1}º produto");
                valorProduto[i] = float.Parse(Console.ReadLine());  
            }

            int[] quantiadeCadaProduto;
            quantiadeCadaProduto = new int[quantidadesProdutos];
            for (var i = 0; i < quantidadesProdutos; i++)
            {
                Console.WriteLine($"qual a quantidade do {i + 1}º produto");
                quantiadeCadaProduto[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($@"=======================================================
|      NOME      |     QUANTIDADE     |     VALOR     |
=======================================================
            "); 

            for (var i = 0; i < quantidadesProdutos; i++)
            {
                Console.WriteLine($@"|      {nomeProdutos[i]}       |         {quantiadeCadaProduto[i]}          |       {valorProduto[i]}       |                                   
                ");
            }
            
            Console.WriteLine(@"=======================================================");
               
        }
    }
}
