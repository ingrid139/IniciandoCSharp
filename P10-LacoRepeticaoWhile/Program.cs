using System;

namespace P10_LacoRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int total = 0;

            while (contador <= 10)
            {
                total += contador;

                // contador = contador + 1;
                // contador += 1;
                contador++;
            }

            Console.WriteLine(contador);
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
