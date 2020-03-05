using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

            double salario = 1200.70;

            Console.WriteLine(salario);

            double idade = 15 / 2.0;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            int valorUm = 5;
            int valorDois = 2;
            int resultado = valorUm / valorDois;
            Console.WriteLine(resultado);

            double variavelDouble = 2.0;
            double valorUmDouble = 5.0;
            double resultadoInteiro = valorUm / valorDois;
            double resultadoDouble = valorUm / variavelDouble;
            double resultadoDoubleDois = valorUmDouble / valorDois;


            Console.WriteLine("Resultado inteiro é: " + resultadoInteiro);
            Console.WriteLine("Resultado double é : " + resultadoDouble);
            Console.WriteLine("Resultado double dois é: " + resultadoDoubleDois);

            Console.WriteLine("A execução acabou. Tecle enter para sair . . . ");
            Console.ReadLine();
        }
    }
}
