using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta_errada = true;
            do
            {   
            Console.WriteLine("qual operação deseja fazer: sendo[1] Soma, sendo[2] Subitração, sendo[3] Divisão, sendo[4] Multiplicação: ");
            string resposta = Console.ReadLine().ToLower(); 
            switch (resposta)
            {
                case "1":
                    Console.WriteLine("qual o 1º numero?");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual o 2º numero?");
                    double n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O resultado é: {Somar(n1, n2)}");
                    break;
                case "2":
                    Console.WriteLine("qual o 1º numero?");
                    double n3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual o 2º numero?");
                    double n4 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O resultado é: {Subitrair(n3, n4)}");
                    break;
                case "3":
                    Console.WriteLine("qual o 1º numero?");
                    double n5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual o 2º numero?");
                    double n6 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O resultado é: {Dividir(n5, n6)}");
                    break;
                case "4":
                    Console.WriteLine("qual o 1º numero?");
                    double n7 = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual o 2º numero?");
                    double n8 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O resultado é: {Multiplicar(n7, n8)}");
                    break;
                default:
                    Console.WriteLine("resposta invalida, tente outra operação");
                    resposta_errada = false; 
                    break;
            }   
            } while (resposta_errada == false);
        }
        static double Somar(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero + SegundoNumero;
        }

        static double Subitrair(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero + SegundoNumero;
        }
        
        static double Multiplicar(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero + SegundoNumero;
        }
        
        static double Dividir(double PrimeiroNumero, double SegundoNumero)
        {
            return PrimeiroNumero + SegundoNumero;
        }

        
    }
}
