using System;

namespace Mathematics
{
    public class Cartesian
    {
        public void DrawPlan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int i = 20; i >= 0; i--)
                Console.WriteLine(i);

            for (int i = 0; i <= 20; i++)
            {
                Console.SetCursorPosition(5, i);
                Console.Write("|");
            }

            Console.SetCursorPosition(5, 20);
            Console.Write("+");

            for (int i = 0; i < 40; i++)
                Console.Write("-");

            Console.SetCursorPosition(5, 21);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
                if (i == 9)
                {
                    for (int i2 = 0; i2 < 10; i2++)
                    {
                        Console.Write("1 ");
                    }
                    Console.SetCursorPosition(25, 22);
                    for (int i3 = 0; i3 < 10; i3++)
                    {
                        Console.Write(i3 + " ");
                    }
                }
            }

            Console.SetCursorPosition(45, 21);
            Console.Write("2 ");
            Console.SetCursorPosition(45, 22);
            Console.Write("0 ");

            DrawLine();
        }

        public void DrawLine()
        {
            // int xCf = xV - (2*xR);
            int xCf = 5;
            // int yCf = -(((yV - yR) / -2) - yR);
            int yCf = 10;

            // int size = 5;

            int yR = 0;
            for (int xR = 0; xR <= 20; xR++)
            {
                int xV = 2 * xR + xCf;
                int yV = yR - (2 * (yR - yCf));
                Console.SetCursorPosition(xV, yV);

                Console.Write("o");
                yR++;
            }

            Console.SetCursorPosition(5, 25);
        }

    }
}






