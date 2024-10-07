public class Trokut : GeometrijskiLik
{
    Duzina AB;
    Duzina BC;
    Duzina CA;

    public Trokut(Tocka a, Tocka b, Tocka c)
    {
        this.AB = new Duzina(a, b);
        this.BC = new Duzina(b, c);
        this.CA = new Duzina(c, a);
        Console.WriteLine("Trokut je stvoren");
    }
}