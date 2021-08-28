using System;
using System.IO;
using System.Threading;

namespace TextEditor
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
            Console.WriteLine("---Editor de Textos---");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir / criar arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 0: System.Environment.Exit(1); break;
                default: Console.WriteLine("Opção desconhecida."); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var arquivo = new StreamReader(path))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo:");
            Console.WriteLine("(Pressione Esc para sair)");
            Console.WriteLine("------------------------");
            string texto = "";

            do
            {
                texto += (Console.ReadLine() + "\n");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);


            Console.WriteLine("-----------");
            Console.Write(texto);

            Salvar(texto);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Em qual caminho deseja salvar o arquivo?");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(text);
            }

            Console.WriteLine($"Arquivo salvo com sucesso em {path}");
            Console.ReadLine();
            Menu();

        }
    }
}

