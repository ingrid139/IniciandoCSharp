using System;

namespace P16.SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchCaseMes();
            SwitchCaseFarol();
            Console.ReadKey();
        }


        public static void SwitchCaseMes()
        {
            Console.WriteLine("16 Switch Case quantos dias tem no mês");
            
            //Exemplo
            Console.WriteLine("Digite um mês");
            string mes = Console.ReadLine();

            switch (mes)
            {
                case "Janeiro":
                case "Março":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    Console.WriteLine("Este mês tem 31 dias");
                    break;
                case "Fevereiro":
                    Console.WriteLine("Este mês tem 28 ou 29 dias");
                    break;
                default:
                    Console.WriteLine("Este mês tem 30 dias");
                    break;
            }
        }

        public static void SwitchCaseFarol()
        {
            Console.WriteLine("16 Switch Case Farol");

            //Exercicio
            Console.WriteLine("Digite um cor do semáforo");
            string mes = Console.ReadLine();

            switch (mes.ToLower())
            {
                case "verde":
                    Console.WriteLine("Farol verde. Siga em frente.");
                    break;
                case "amarelo":
                    Console.WriteLine("Farol amarelo. Atenção.");
                    break;
                case "vermelho":
                    Console.WriteLine("Farol vermelho. Pare.");
                    break;
                default:
                    Console.WriteLine("Por favor digite uma cor valida.");
                    break;
            }
        }
    }
}
