using System;
using System.Collections.Generic;

namespace P14_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14 foreach");

            string curso = "AceleraDev Women 2020";
            var digitos = new List<char>();
            var espaco = new List<char>();
            var letras = new List<char>();


            foreach (var letra in curso.ToCharArray())
            {
                if (char.IsLetter(letra))
                {
                    letras.Add(letra);
                    Console.WriteLine("Letra: " + letra);

                }
                if (char.IsWhiteSpace(letra))
                {
                    espaco.Add(letra);
                    Console.WriteLine("Espaço: " + letra);
                }
                if (char.IsDigit(letra))
                {
                    digitos.Add(letra);
                    Console.WriteLine("Digito: " + letra);
                }
            }

            Console.WriteLine(letras.Count);
            Console.WriteLine(digitos.Count);
            Console.WriteLine(espaco.Count);

            Console.ReadKey();
        }
    }
}
