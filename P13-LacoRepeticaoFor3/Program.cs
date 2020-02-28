using System;

namespace P13_LacoRepeticaoFor3
{
    class Program
    {
        static void Main(string[] args)
        {
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                        break;

                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
