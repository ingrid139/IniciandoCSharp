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

            Console.ReadKey();
        }
    }
}
