using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            Console.WriteLine(idade);
            int idadeIngrid = idade;

            idade = 40;

            Console.WriteLine(idade);
            Console.WriteLine("Ingrid: " + idadeIngrid);

            Console.ReadLine();
        }
    }
}
