using System;

namespace CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando variáveis");

            int idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("Execução finalizada. Tecle enter para sair. . . ");
            Console.ReadKey();
        }
    }
}
