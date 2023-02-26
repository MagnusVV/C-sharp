using System;
namespace Assignment_2
{
	public class Cat
	{
		public string Name { get; }
		public bool Zombie { get; set; }

		public Cat(string name, bool isZobmie)
		{
			Name = name;
			Zombie = isZobmie;
		}

		public string Speak()
		{
			if (Zombie)
			{
                return "Braaaaains!";
            }

			return "Meow!";
		}

		public void Eat(Cat cat)
		{
			if (Zombie && !cat.Zombie)
			{
                cat.Zombie = true;
                Console.WriteLine("Nomnomnom");
            }
			if (!Zombie)
			{
                Console.WriteLine($"What?! I will not eat {cat.Name}!");
            }
		}
	}
}

