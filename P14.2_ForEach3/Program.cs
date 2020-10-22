using System;
using System.Collections.Generic;

namespace P14._2_ForEach3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício pares e ímpares Listas");

            List<int> numeros = new List<int>();
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            foreach (var item in numeros)
            {
                if (item % 2 == 0)
                {
                    pares.Add(item);
                }
                else
                {
                   impares.Add(item);
                }
            }

            Console.WriteLine("Numeros pares");
            pares.Sort();
            foreach (var item in pares)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine("Numeros impares");
            impares.Sort();
            foreach (var item in impares)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
