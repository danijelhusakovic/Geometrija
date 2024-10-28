public class Pravokutnik : GeometrijskiLik
{

    public Tocka A, B, C, D;
    public double a, b;

    /// <summary>
    /// A rectangle. Receives four points.
    /// </summary>
    /// <param name="A"></param>
    /// <param name="B"></param>
    /// <param name="C"></param>
    /// <param name="D"></param>
    public Pravokutnik(Tocka A, Tocka B, Tocka C, Tocka D)
    {
        this.A = A;
        this.B = B;
        this.C = C;
        this.D = D;
        a = new Duzina(this.A, this.B).Duljina();
        b = new Duzina(this.B, this.C).Duljina();
    }
    
    /// <summary>
    /// Calculates the extent of the rectangle
    /// </summary>
    /// <returns></returns>
    public override double Opseg()
    {
        return 2 * (a + b);
    }

    /// <summary>
    /// Calculates the area of the rectangle
    /// </summary>
    /// <returns></returns>
    public override double Povrsina()
    {
        return a * b;
    }

    /// <summary>
    /// Checks whether the rectangle is actually a square.
    /// </summary>
    /// <returns></returns>
    public bool JeKvadrat()
    {
        return a == b;
    }
}