using System;
using System.IO;

namespace bninamango
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Instructions();

            Player player = new Player('P', Vector2.Zero);

            Vector2 direction = Vector2.Zero;

            int speed = 1;

            player.Draw();

            while (true)
            {
                #region Input Player
                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {
                    default:
                        break;

                    case ConsoleKey.UpArrow:

                        direction = Vector2.Down;

                        break;

                    case ConsoleKey.DownArrow:

                        direction = Vector2.Up;

                        break;

                    case ConsoleKey.RightArrow:

                        direction = Vector2.Right;

                        break;

                    case ConsoleKey.LeftArrow:

                        direction = Vector2.Left;

                        break;
                }
                #endregion

                Console.Clear();

                player.Move(direction * speed);

                player.Draw();
            }

            void Intro()
            {
                string[] lines = File.ReadAllLines("Title.txt");

                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.WriteLine();

                Console.ReadKey();

                Console.Clear();
            }

            void Instructions()
            {
                Console.WriteLine("Instructions");
                Console.WriteLine("▲ : Up movement");
                Console.WriteLine("▼ : Down movement");
                Console.WriteLine("► : Right movement");
                Console.WriteLine("◄ : Left movement");

                Console.WriteLine();

                Console.WriteLine("Press any key to continue");

                Console.ReadKey();

                Console.Clear();
            }
        }
    }
}