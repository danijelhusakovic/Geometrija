public class Duzina
{
    public Tocka A;
    public Tocka B;
    public Duzina(Tocka A, Tocka B)
    {
        this.A = A;
        this.B = B;
    }

    /// <summary>
    /// Calculates the length
    /// </summary>
    public double Duljina()
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }
}