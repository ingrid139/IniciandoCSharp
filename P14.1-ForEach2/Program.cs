using System;
using System.Collections.Generic;

namespace P14._1_ForEach2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14.1 foreach");
            
            
            Console.WriteLine("Exercício Departamento");

            string[] deptos = { "TI", "RH", "CO", "FN" };


            //foreach (para cada) depto (departamento) in (contido em) deptos (departamentos)

            foreach (var depto in deptos)
            {
                Console.WriteLine(depto);
            }


            Console.WriteLine(); 
            Console.WriteLine();

            Console.WriteLine("Exercício Listas");

            List<int> numeros = new List<int>();
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);

            numeros.Sort();

            foreach (var item in numeros)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
