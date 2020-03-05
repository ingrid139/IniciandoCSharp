using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeCarla = 16;
            int quantidadePessoas = 1;

            if (idadeCarla >= 18)
            {
                Console.WriteLine("Carla possui mais de 18 anos. Pode entrar");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Carla não possui 18 anos, mas está acompanhada");
                }
                else
                {
                    Console.WriteLine("Carla não possui mais de 18 anos e não está acompanhada, não pode entrar");
                }
            }

            Console.ReadLine();
        }
    }
}
