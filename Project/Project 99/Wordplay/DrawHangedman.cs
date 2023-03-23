using System;
namespace Wordplay
{
	static class DrawHangedman
	{
		public static int[] CurrentDrawEndPosition = { 0, 3, 15, 21, 22, 25, 26, 28, 30, 32, 35, 39 };
		public static int [] XdrawPosition = Array.ConvertAll(File.ReadAllLines("x-coordinates.txt"), int.Parse);
        public static int[] YdrawPosition = Array.ConvertAll(File.ReadAllLines("y-coordinates.txt"), int.Parse);
        public static string[] HangedMansParts = File.ReadAllLines("HangedMan.txt");


		public static void Draw(int counter)
		{
			for (int position = 0; position < CurrentDrawEndPosition[counter]; position++)
			{
                var x = Console.WindowWidth / 2 + XdrawPosition[position];
                var y = Console.WindowHeight + YdrawPosition[position] - 5;

				Console.SetCursorPosition(x, y);
				Console.Write(HangedMansParts[position]);
            }
		}
	}
}

