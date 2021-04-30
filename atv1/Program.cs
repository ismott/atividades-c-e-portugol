using System;

namespace atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------idade em ano mês, horas e minutos---------------------

            Console.WriteLine("Qual a sua idade meu jovem?");
            double idade = double.Parse(Console.ReadLine());

            double meses = idade * 12;
            double dias = idade * 365;
            double horas = idade * 8760;
            double minutos = idade * 525600;
 
            Console.WriteLine("sua idade em meses, dias, horas e minutos é:"); 
            Console.WriteLine("meses: " + meses);
            Console.WriteLine("dias: " + dias);
            Console.WriteLine("horas: " + horas);
            Console.WriteLine("minutos: " + minutos);   

        }
    }
}
