using System;

namespace Calculator
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

            Console.WriteLine("Qual operação você deseja realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Operacao(1); break;
                case 2: Operacao(2); break;
                case 3: Operacao(3); break;
                case 4: Operacao(4); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Operacao(int operacao)
        {
            Console.Clear();

            string titulo;

            switch (operacao)
            {
                case 1: titulo = "Soma"; break;
                case 2: titulo = "Subtração"; break;
                case 3: titulo = "Divisão"; break;
                case 4: titulo = "Multiplicação"; break;
                default: titulo = ""; break;
            }

            Console.WriteLine("---" + titulo + "---");
            Console.WriteLine("Primeiro valor:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            double v2 = double.Parse(Console.ReadLine());

            double resultado;

            switch (operacao)
            {
                case 1: resultado = v1 + v2; break;
                case 2: resultado = v1 - v2; break;
                case 3: resultado = v1 / v2; break;
                case 4: resultado = v1 * v2; break;
                default: resultado = 0; break;
            }

            Console.WriteLine($"O resultado da operação é: {resultado}");

            Console.ReadKey();
            Menu();
        }
    }
}
