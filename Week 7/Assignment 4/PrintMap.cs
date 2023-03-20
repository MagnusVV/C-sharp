using System;
namespace Assignment_4
{
	public class PrintMap
	{
		public void Draw(string[] mapFile)
		{
			foreach (var row in mapFile)
			{
				Console.WriteLine(row);
			}
		}

		public void LandAmount (string[] mapFile)
        {
			int landAmount = 0;

            foreach (var row in mapFile)
            {
				char land = '#';

				landAmount += row.Count(occurence =>(occurence == land));
            }

            Console.WriteLine($"Amount of land: {landAmount}");
        }
    }
}