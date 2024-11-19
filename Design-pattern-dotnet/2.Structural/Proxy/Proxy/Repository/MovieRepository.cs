using System.Diagnostics;
using Microsoft.Extensions.Caching.Memory;

namespace Proxy;

public class MovieRepository
{
    private IMemoryCache _memoryCache { get; set; }
    private Movie movie;
    public MovieRepository()
    {
        movie = new();
        _memoryCache = new MemoryCache(new MemoryCacheOptions());

    }
    string key = "Movies";
    public List<Movie> GetMovies(Func<Movie, bool> func)
    {
        if (_memoryCache.TryGetValue(key, out List<Movie>? result))
        {
            var movies = result.Where(func).ToList();
            if (movies.Count == 0)
            {
                movies = movie.GetMovies(func);
                result.AddRange(movies);
                _memoryCache.Set(key, result, DateTime.Now.AddMinutes(30));
            }
            else
            {
                var sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("Get from MemoryCache: Starting");
                Console.WriteLine("Get from MemoryCache: Running for {0} seconds", sw.Elapsed.TotalSeconds);
                Console.WriteLine("Get from MemoryCache: Done");

            }
            result = movies;
        }
        else
        {
            var movies = movie.GetMovies(func);
            _memoryCache.Set(key, movies, DateTime.Now.AddMinutes(30));
            result = movies;
        }

        return result;
    }

}
