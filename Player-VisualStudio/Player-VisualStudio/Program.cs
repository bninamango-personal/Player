using System;

namespace bninamango
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player('@', new Vector2(0, 0));

            int speed = 1;

            Vector2 direction = new Vector2(0, 0) * speed;

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
                
                player.Move(direction);

                //player.Draw();
            }
        }
    }
}