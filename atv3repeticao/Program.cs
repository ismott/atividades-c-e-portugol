using System;

namespace atv3repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coloque seu nome aqui");
            string nome = Console.ReadLine();
            if (nome == "")
            {
                Console.WriteLine("nome envaldo!");
            }
            Console.WriteLine("agora insira sua idade");
            float idade = float.Parse(Console.ReadLine());
            if (idade <0 || idade >150)
            {
               Console.WriteLine("idade envalida!"); 
            } 
            Console.WriteLine("agora insira um salario");
            float salario = float.Parse(Console.ReadLine());
            if (salario <= 0)
            {
                Console.WriteLine("salario envalido");
            }
            Console.WriteLine("idique seu estado civil sendo: s para solteiro(a), c para casado(a), v para viuvo(a), d para divorciado(a)");
            string estado_civil = Console.ReadLine().ToLower();
            if (estado_civil == "s" || estado_civil == "c" || estado_civil == "v" || estado_civil == "d")
            {
               Console.WriteLine("ok estado civil correto"); 
            }
            else
            {
                Console.WriteLine("estado civil invalido");
            }
        }
    }
}
