﻿using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            // character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Cursos de tecnologia " + 2020;
            string cursosProgramacao =
@" - .NET
 - Java
 - Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            Console.ReadLine();
        }
    }
}
