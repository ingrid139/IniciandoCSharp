using System;

namespace P10_LacoRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - While");

            Console.WriteLine("Digite um valor para dar início a contagem regressiva");
            string contadorDigitado = Console.ReadLine();
            int contador = Int32.Parse(contadorDigitado);
            int total = 0;

            Console.WriteLine();

            while (contador >= 0)
            {
                //total += contador;
                total = contador;
                Console.WriteLine(total);

                // contador = contador + 1;
                // contador += 1;
                contador--;
            }

            Console.ReadLine();
        }
    }
}
