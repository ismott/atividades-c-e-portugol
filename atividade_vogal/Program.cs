using System;

namespace atividade_vogal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira seu nome aqui");
            string nome = Console.ReadLine().ToLower();

            string caracter = nome.Substring(0, 1);

            switch (caracter)
            {
                case "a":
                        Console.WriteLine("seu nome começa com: " + caracter + " de amarelo");
                    break;
                case "e":
                        Console.WriteLine("seu nome começa com: " + caracter + " de errante");
                    break;
                case "i":
                        Console.WriteLine("seu nome começa com: " + caracter + " de imaginario");
                    break;
                case "o":
                        Console.WriteLine("seu nome começa com: " + caracter + " de orlando");
                    break;
                case "u":
                        Console.WriteLine("seu nome começa com: " + caracter + " de urubu");
                    break;
                default:
                        Console.WriteLine("seu nome não começa com vogal");
                    break;
            }
            
            // ---------------------------------------------------------------------------

            Console.WriteLine("que numero de I a X vc gostari de saber em indo arábico?");
            string romano = Console.ReadLine().ToUpper();

            switch (romano)
            {
                case "I":
                        Console.WriteLine("I equivale a 1");
                    break;
                case "II":
                        Console.WriteLine("II equivale a 2");
                    break;
                case "III":
                        Console.WriteLine("III equivale a 3");
                    break;
                case "VI":
                        Console.WriteLine("VI equivale a 4");
                    break;
                case "V":
                        Console.WriteLine("V equivale a 5");
                    break;
                case "IV":
                        Console.WriteLine("IV equivale a 6");
                    break;
                case "IIV":
                        Console.WriteLine("IIV equivale a 7");
                    break;
                case "IIIV":
                        Console.WriteLine("IIIV equivale a 8");
                    break;
                case "IX":
                        Console.WriteLine("IX equivale a 9");
                    break;
                case "X":
                        Console.WriteLine("X equivale a 10");
                    break;
                default:
                        Console.WriteLine("porfavor insira um numero de I a X");
                    break;
            }
            

        }
    }
}
