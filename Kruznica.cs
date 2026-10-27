public class Kruznica : Oblik
{
    public Tocka S;
    public double radijus;

    public Kruznica(Tocka S, double radijus)
    {
        this.S = S;
        this.radijus = radijus;
    }

    public override double Opseg()
    {
        Console.WriteLine("Opseg kruznice");
        return 0;
    }
}