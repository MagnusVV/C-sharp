using System;
namespace Assignment_3
{
	public class Cinema
    {
        public Movie Movie { get; set; }

        public void MovieInformation()
        {
            Console.WriteLine($"We are currently showing: {Movie.Name} ({Movie.AgeRating} years or older, {Movie.Price}:-)");
        }

        public void ShowMovieTo(Person person)
        {
            if (person.Age < Movie.AgeRating)
            {
                Console.WriteLine($"Sorry {person.Name}. You're not old enough.");
                return;
            }
            if (person.Money < Movie.Price)
            {
                Console.WriteLine($"Sorry {person.Name}. You're too poor.");
                return;
            }

            person.Money -= Movie.Price;
            
            Console.WriteLine($"Welcome {person.Name}, please enjoy the movie {Movie.Name}!");
            
        }
    }
}