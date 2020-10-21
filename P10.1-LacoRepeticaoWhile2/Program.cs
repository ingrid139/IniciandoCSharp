using System;

namespace P10._1_LacoRepeticaoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10.1 - While 2");
            int contador = 1;
            int total = 0;

            while (contador <= 10)
            {
                //total += contador;
                total = contador;
                Console.WriteLine(total);

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
