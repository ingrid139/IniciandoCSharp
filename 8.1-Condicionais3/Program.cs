using System;

namespace _8._1_Condicionais3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8.1 - Condicionais 3");

            Console.WriteLine("Informe a nota 1 exercicio 2");

            string n1Digitadaex2 = Console.ReadLine();
            int n1ex2 = Int32.Parse(n1Digitadaex2);

            Console.WriteLine("Informe a nota 2 exercicio 2");

            string n2Digitadaex2 = Console.ReadLine();
            int n2ex2 = Int32.Parse(n2Digitadaex2);

            double mediaex2 = (n1ex2 + n2ex2) / 2;

            if (mediaex2 >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");

            }

            Console.WriteLine("O média é: " + mediaex2);  

            Console.ReadLine();
        }
    }
}
