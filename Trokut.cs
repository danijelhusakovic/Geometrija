public class Trokut : Oblik
{
    public Tocka A;
    public Tocka B;
    public Tocka C;

    public Trokut(Tocka A, Tocka B, Tocka C)
    {
        this.A = A;
        this.B = B;
        this.C = C;
    }

    public override double Opseg()
    {
        Console.WriteLine("Opseg trokuta");
        return 0;
    }
}