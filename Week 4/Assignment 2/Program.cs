var movie = new Movie()
{
    Name = "Ghostbusters",
    AgeRating = 11,
    Price = 60
};

var cinema = new Cinema()
{
};

cinema.MovieInformation(movie);



class Movie
{
    public string Name { get; set; }
    public int AgeRating = 0;
    public int Price = 0;
}

class Cinema
{

    public void MovieInformation(Movie movie)
    {
        Console.WriteLine($"We are currently showing: {movie.Name} ({movie.AgeRating} years or older, {movie.Price}:-)");
    }
}
