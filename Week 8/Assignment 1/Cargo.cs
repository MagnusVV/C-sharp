using System;
namespace Assignment_1
{
	public class Cargo
	{
        public string Description { get; }

		public int Size { get; }

        public Cargo(string description, int size)
		{
			Description = description;

			Size = size;
		}
	}
}

