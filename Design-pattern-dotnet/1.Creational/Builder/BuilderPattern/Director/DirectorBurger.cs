
namespace Builder;

public class DirectorBurger
{
  public DirectorBurger()
  {
  }

  public void Construct()
  {
    //var burger = ConcreteBuilderBurger.Create()
    var clasica = new ConcreteBuilderBurger()
      .withCheese()
      .withLetture()
      .withDip()
      .build();

    Console.WriteLine("Amburgueza clasica tiene: {0}", clasica);

    var Vegetariana = new ConcreteBuilderBurger()
      .withLetture()
      .withTomato()
      .withDip()
      .build();

    Console.WriteLine("Amburgueza Vegetariana tiene: {0}", Vegetariana);
  }

}
