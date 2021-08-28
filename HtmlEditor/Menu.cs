using System;
using System.Threading;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            short option = short.Parse(Console.ReadLine());
            HandleButtonOption(option);
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("|");
                for (int ix = 0; ix <= 30; ix++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(11, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Editar arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(0, 13);
            Console.Write("Opção: ");
        }
        public static void HandleButtonOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(1);
                        break;
                    }
                default:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Erro: Opção desconhecida...");
                        Thread.Sleep(1500);
                        Show();
                        break;
                    }
            }
        }
    }




}