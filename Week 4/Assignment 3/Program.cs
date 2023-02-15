using Assignment_3;

var movie = new Movie()
{
    Name = "Ghostbusters",
    AgeRating = 11,
    Price = 60
};

var person = new Person()
{
    Name = "Guybrush"
};

var cinema = new Cinema()
{
    Movie = movie
};

cinema.MovieInformation();

cinema.ShowMovieTo(person);