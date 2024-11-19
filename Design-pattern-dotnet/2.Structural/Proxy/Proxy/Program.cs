

using System.Text.Json;

using Proxy;

///<Pattern:Proxy>
/// is a structural pattern that provides an object representing another object. 
/// It acts as an intermediary or placeholder, controlling access to the original object. 
/// This can be useful for various purposes, such as lazy loading, access control, logging, etc

///<Cases:Use-it>
/// 1.- Lazy Loading: You can use a proxy to postpone loading an expensive object until it is really necessary.
/// This is useful when working with objects that are resource intensive and not needed immediately
/// 2.- Access Control: A proxy can act as an intermediary to control access to an object.
/// You can implement authorization, authentication, or registration logic before allowing the client to access the actual object
/// 3.- Logging and Auditing: You can use a proxy to track calls to an object, log information, or perform audits.
/// 4.- Cache: You can implement a proxy to cache the results of expensive operations and return the result
/// cached if the same operation is requested again

// this example it's to MemoryCache, example very basic, here not use injection dependency

static string GetJson(List<Movie> movies)
{
    return JsonSerializer.Serialize(movies, new JsonSerializerOptions { WriteIndented = true });
}

IMovie movieProxy = new MovieProxy();
var movies = movieProxy.GetMovies(p => p.Title.Contains("The"));
var resp = GetJson(movies);
Console.WriteLine("Result-1: {0}", resp);
movies = movieProxy.GetMovies(p => p.Title.Contains("Dark"));
resp = GetJson(movies);
Console.WriteLine("Result-2: {0}", resp);
movies = movieProxy.GetMovies(p => p.Title.Contains("Godfather"));
resp = GetJson(movies);
Console.WriteLine("Result-3: {0}", resp);
movies = movieProxy.GetMovies(p => p.Title.Contains("List"));
resp = GetJson(movies);
Console.WriteLine("Result-4: {0}", resp);
movies = movieProxy.GetMovies(p => p.Title.Contains("Redemption"));
resp = GetJson(movies);
Console.WriteLine("Result-5: {0}", resp);
movies = movieProxy.GetMovies(p => p.Title.Contains("xx"));
resp = GetJson(movies);
Console.WriteLine("Result-6: {0}", resp);
movies = movieProxy.GetMovies(p => p.Title.Contains("Godfather"));
resp = GetJson(movies);
Console.WriteLine("Result-7: {0}", resp);



