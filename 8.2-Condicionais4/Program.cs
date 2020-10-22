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

            if (farol.ToLower() != "verde" &&
                farol.ToLower() != "amarelo" &&
                farol.ToLower() != "vermelho")
            {
                Console.WriteLine("Por favor digite uma cor valida.");

            }
            else if (farol.ToLower() == "verde")
            {
                Console.WriteLine("Farol verde. Siga em frente.");
            }
            else if (farol.ToLower() == "amarelo")
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
