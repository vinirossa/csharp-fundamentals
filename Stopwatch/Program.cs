using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("---Cronômetro---");

            Console.WriteLine("1 = Segundo");
            Console.WriteLine("2 = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Em qual unidade deseja contar?");
            double choice = double.Parse(Console.ReadLine());
            int multiplier = 1;

            if (choice == 1 || choice == 2)
            {
                if (choice == 2)
                    multiplier *= 60;

                Console.WriteLine("Digite o tempo desejado:");
                double time = double.Parse(Console.ReadLine());

                Start(time * multiplier);
            }
            else if (choice == 0)
            {
                Console.Clear();
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Opção desconhecida.");
                Thread.Sleep(1000);
                Menu();
            }
        }

        static void Start(double maxtime)
        {
            Console.Clear();

            double curTime = 0;
            double maxTime = maxtime;

            while (curTime < maxTime)
            {
                curTime++;
                Console.WriteLine(curTime + "s");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Fim da contagem");
            Console.WriteLine("Retornando para o menu...");
            Thread.Sleep(1000);
            Menu();
        }
    }
}
