using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeCarla = 18;
            bool acompanhada = true;

            // string mensagemAdicional;
            //string mensagemAdicional = "";
            string mensagemAdicional = string.Empty;

            if (acompanhada)
                mensagemAdicional = "Carla está acompanhada";
            else
                mensagemAdicional = "Carla não está acompanhada";

            if (idadeCarla >= 18 || acompanhada == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
