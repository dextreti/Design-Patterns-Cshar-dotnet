namespace Proxy;

public interface IMovie
{
    List<Movie> GetMovies(Func<Movie, bool> func);

}
