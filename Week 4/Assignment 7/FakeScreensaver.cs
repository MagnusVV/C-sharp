using System;
namespace Assignment_7
{
	public class FakeScreensaver
	{
        public void Draw()
        {
            var Random = new Random();

            while (true)
            {
                System.Threading.Thread.Sleep(100);

                var Color = (ConsoleColor)Random.Next(1, 16);

                var X = Random.Next(1, Console.WindowWidth);
                var Y = Random.Next(1, Console.WindowHeight);

                var Width = Random.Next(1, (Console.WindowWidth));
                var Height = Random.Next(1, (Console.WindowHeight));

                Console.BackgroundColor = Color;

                for (int y = 0; y < Height; y++)
                {
                    Console.SetCursorPosition(X, Y + y);

                    for (int x = 0; x < Width; x++)
                    {
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}

