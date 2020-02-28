using System;

namespace P11_LacoRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int contador = 0; contador <= 10; contador++)
            {
                total += contador;
            }

            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
