using System;
namespace Assignment_1
{
	public class FizzBuzz
	{
		public void UseFizzBuzz()
		{
			for (int i = 1; i < 101; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
                    Console.WriteLine("FizzBuzz");
					continue;
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }

                Console.WriteLine(i);
			}
		}
	}
}

