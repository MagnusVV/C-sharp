using Assignment_3;

var movie = new Movie()
{
    Name = "Ghostbusters",
    AgeRating = 11,
    Price = 60
};

var person = new Person()
{
    Name = "Guybrush",
    Age = 19,
    Money = 100
};

var cinema = new Cinema()
{
    Movie = movie
};

Console.WriteLine($"{person.Name} has {person.Money}:- in his pocket");

cinema.ShowMovieTo(person);

Console.WriteLine($"{person.Name} has {person.Money}:- in his pocket");