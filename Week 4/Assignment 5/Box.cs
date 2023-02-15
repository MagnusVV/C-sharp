using System;
namespace Assignment_5
{
	public class Box
	{
		public int X { get; set;}
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw()
        {
            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(X, Y + y);

                for (int x = 0; x < Width; x++)
                {
                    Console.Write('X');
                }
            }           
        }
    }
}

