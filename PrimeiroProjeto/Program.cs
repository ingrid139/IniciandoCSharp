using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Projeto no Visual Studio!");
            Console.WriteLine("Olá, eu sou a Ingrid!");

            string nome = Console.ReadLine();

            Console.WriteLine("O nome digitado foi: " + nome);


            Console.WriteLine();
            Console.WriteLine();

            //*********************************************************
            Console.WriteLine("Exemplo Aula 1 - fluxograma");

            Console.WriteLine("Informe a nota 1");

            string n1Digitada = Console.ReadLine();
            int n1 = Int32.Parse(n1Digitada);

            Console.WriteLine("Informe a nota 2");

            string n2Digitada = Console.ReadLine();
            int n2 = Int32.Parse(n2Digitada);

            double media = (n1 + n2) / 2;

            Console.WriteLine("O média é: " + media);

            Console.WriteLine();
            Console.WriteLine();

            //*********************************************************
            Console.WriteLine("Informe sua idade");

            string idadeDigitada = Console.ReadLine();
            int idade = Int32.Parse(idadeDigitada);

            if (idade >= 18)
            {
                Console.WriteLine("É maior de idade");
            }
            else
            {
                Console.WriteLine("Não é maior de idade");

            }

            Console.WriteLine();
            Console.WriteLine();
            //*********************************************************
            
            Console.ReadKey();
        }
    }
}
