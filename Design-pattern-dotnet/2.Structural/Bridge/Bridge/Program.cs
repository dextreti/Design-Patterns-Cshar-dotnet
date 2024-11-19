
using p = Bridge.Problem;
using s = Bridge.Solution;

/*  
    Intención del patrón desacoplar una abstracción de su implementación de manera que ambas puedan variar independientemente.
    Publicar la interfaz en una jerarquía de herencias y ocultar la implementación en su propia jerarquía de herencia.
    Además de encapsulación, se usa para aislamiento.    
*/

Problem();
Console.WriteLine("--------------------------------------------");
Solution();


void Problem()
{
    p.IFigure Ifigure = new p.Circle();
    Ifigure.DrawBlackColor();
    Ifigure.DrawRedColor();

    Ifigure = new p.Triangle();
    Ifigure.DrawBlackColor();
    Ifigure.DrawRedColor();

    Ifigure = new p.Rectangle();
    Ifigure.DrawBlackColor();
    Ifigure.DrawRedColor();
}

void Solution()
{

    s.Figure figure = new s.Circle(new s.Red());
    figure.Draw();
    figure = new s.Circle(new s.Black());
    figure.Draw();

    figure = new s.Rectangle(new s.Red());
    figure.Draw();

    figure = new s.Rectangle(new s.Black());
    figure.Draw();

    figure = new s.Triangle(new s.Red());
    figure.Draw();

    figure = new s.Triangle(new s.Black());
    figure.Draw();

}
