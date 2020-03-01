using System;

namespace P12_LacoRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);
            Console.ReadLine();
        
            //exemplo extra
            //for (int numero = 0; numero <= 10; numero++)
            //{
            //    Console.Write("Tabuada do " + numero + " : ");

            //    for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            //    {
            //        Console.Write(numero * multiplicador);
            //        Console.Write(" ");
            //    }

            //    Console.WriteLine();
            //}


        Console.ReadLine();
        }
    }
}
