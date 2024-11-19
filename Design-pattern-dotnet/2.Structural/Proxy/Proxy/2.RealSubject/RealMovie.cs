

namespace Proxy;

public class RealMovie : IMovie
{
    private readonly MovieRepository movieRepository;
    public RealMovie()
    {
        movieRepository = new();
    }
    public List<Movie> GetMovies(Func<Movie, bool> func)
    {
        return movieRepository.GetMovies(func);
    }
}
