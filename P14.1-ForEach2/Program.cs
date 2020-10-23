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
            
            //array
            string[] deptos = { "TI", "RH", "CO", "FN" };

            //o acesso a informação geralmente acontece pelo número da posição (index)
            Console.WriteLine(deptos[2]);

            //foreach (para cada) depto (departamento) in (contido em) deptos (departamentos)

            foreach (var depto in deptos)
            {
                Console.WriteLine(depto);
            }


            Console.WriteLine(); 
            Console.WriteLine();

            Console.WriteLine("Exercício Listas");

            //<[TipoDeDado]> = Tipando
            // instancia = new List<int>()
            List<int> numeros = new List<int>();
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);

            //metodo Sort = ordena os numeros de forma crescente
            numeros.Sort();

            foreach (var item in numeros)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Exemplo Letras Lista Foreach");

            List<string> letras = new List<string>();
            letras.Add("D");
            letras.Add("F");
            letras.Add("A");
            letras.Add("W");

            //metodo Sort = ordena as letras de forma alfabética
            letras.Sort();
            foreach (var letra in letras)
            {
                Console.WriteLine(letra);
            }

            Console.ReadKey();
        }
    }
}
