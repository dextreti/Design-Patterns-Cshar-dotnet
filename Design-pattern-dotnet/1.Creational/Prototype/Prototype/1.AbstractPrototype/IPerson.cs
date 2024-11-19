using System.Reflection.Metadata.Ecma335;

namespace Prototype;

public interface IPerson<T> where T : IPerson<T>
{

    T Clone();
}
