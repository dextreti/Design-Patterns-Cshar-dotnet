
namespace Proxy;

public class MovieProxy : IMovie
{
    private RealMovie? realMovie;

    public List<Movie> GetMovies(Func<Movie, bool> func)
    {
        if (realMovie == null)
        {
            realMovie = new RealMovie();
        }
        return realMovie.GetMovies(func);
    }
}
