using System;

namespace _8._2_Condicionais4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8.2 - Condicionais 4");
            Console.WriteLine("Exercício proposto FAROL/SEMAFORO");

            string farol = Console.ReadLine();

            if (farol == "verde")
            {
                Console.WriteLine("Farol verde. Siga em frente.");
            }
            else if (farol == "amarelo")
            {
                Console.WriteLine("Farol amarelo. Atenção.");
            }
            else
            {
                Console.WriteLine("Farol vermelho. Pare.");
            }

            Console.ReadLine();
        }
    }
}
