using System;

namespace P12_LacoRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numero = 0; numero <= 10; numero++)
            {
                Console.Write("Tabuada do " + numero + " : ");

                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    Console.Write(numero * multiplicador);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
