using System;
namespace Assignment_3
{
	public class Robot
	{
		public string Name { get; }
		public int Health { get; set; }

		public Robot(string name, int health)
		{
			Name = name;
			Health = health;
		}

		public void Attack(Robot robot)
		{
			var damage = Die.Roll();
			robot.Health -= damage;
			Console.WriteLine($"{Name} attacks {robot.Name} for {damage} points of damage!");
		}
	}
}

