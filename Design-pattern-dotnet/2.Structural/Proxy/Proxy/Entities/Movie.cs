
using System.Diagnostics;

namespace Proxy;

public class Movie
{
    public Movie() { }
    public string Title { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Producer { get; set; } = string.Empty;

    List<Movie> movies;
    public List<Movie> GetMovies(Func<Movie, bool> func)
    {
        var sw = new Stopwatch();
        sw.Start();

        Console.WriteLine("Get from database: Starting");
        movies = new List<Movie>
        {
            new Movie { Title = "The Shawshank Redemption", Director = "Frank Darabont", Producer = "Niki Marvin", Genre = "Drama" },
            new Movie { Title = "Godfather", Director = "Francis Ford Coppola", Producer = "Albert S. Ruddy", Genre = "Crime" },
            new Movie { Title = "The Dark Knight", Director = "Christopher Nolan", Producer = "Emma Thomas, Charles Roven", Genre = "Action" },
            new Movie { Title = "Pulp Fiction", Director = "Quentin Tarantino", Producer = "Lawrence Bender", Genre = "Crime" },
            new Movie { Title = "Schindler's List", Director = "Steven Spielberg", Producer = "Steven Spielberg, Gerald R. Molen", Genre = "Biography" },
        };
        var list = movies.Where(func).ToList();

        Console.WriteLine("Get from database: Running for {0} seconds", sw.Elapsed.TotalSeconds);
        Console.WriteLine("Get from database: Done");

        return list;
    }


}
