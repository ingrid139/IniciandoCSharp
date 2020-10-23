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

            Console.WriteLine();

            while (contador >= 0)
            {
                Console.WriteLine(contador);

                // contador = contador - 1;
                // contador -= 1;
                contador--;
            }

            Console.ReadLine();
        }
    }
}
