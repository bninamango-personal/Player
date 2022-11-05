using System;

namespace bninamango
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player('P', Vector2.Zero);

            Vector2 direction = Vector2.Zero;

            int speed = 1;

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
        }
    }
}