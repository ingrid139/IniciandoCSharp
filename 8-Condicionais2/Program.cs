﻿using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeCarla = 18;
            // int quantidadePessoas = 2;
            // bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;

            if (idadeCarla >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
