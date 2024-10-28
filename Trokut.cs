public class Trokut : GeometrijskiLik
{
    Duzina AB;
    Duzina BC;
    Duzina CA;
    double a, b, c;
    /// <summary>
    /// A triangle. Receives three points
    /// </summary>
    /// <param name="A">First point</param>
    /// <param name="B">Second point</param>
    /// <param name="C">Third point</param>
    public Trokut(Tocka A, Tocka B, Tocka C)
    {
        this.AB = new Duzina(A, B);
        this.BC = new Duzina(B, C);
        this.CA = new Duzina(C, A);

        this.a = this.BC.Duljina();
        this.b = this.CA.Duljina();
        this.c = this.AB.Duljina();
    }


    /// <summary>
    /// Calculates the extent of the triangle
    /// </summary>
    /// <returns></returns>
    public override double Opseg()
    {
        return a + b + c;
    }

    /// <summary>
    /// Calculates the area of the triangle
    /// </summary>
    /// <returns></returns>
    public override double Povrsina()
    {
        double s = S();
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    /// <summary>
    /// Checks whether the triangle is equilateral
    /// </summary>
    /// <returns></returns>
    public bool JeJednakostranican()
    {
        return a == b && b == c;
    }

    /// <summary>
    /// Checks whether the triangle is isosceles
    /// </summary>
    /// <returns></returns>
    public bool JeJednakoKracan()
    {
        return a == b || b == c || c == a;
    }

    /// <summary>
    /// Checks whether the triangle is multi-sided
    /// </summary>
    /// <returns></returns>
    public bool JeRaznostranican()
    {
        return !JeJednakoKracan();
    }

    /// <summary>
    /// Checks whether it is a right triangle
    /// </summary>
    /// <returns></returns>
    public bool JePravokutan()
    {
        List<double> stranice = new List<double> { a, b, c };
        stranice.Sort();

        double hipotenuza = stranice[2];
        double kateta1 = stranice[0];
        double kateta2 = stranice[1];

        return Math.Pow(hipotenuza, 2) == Math.Pow(kateta1, 2) + Math.Pow(kateta2, 2);
    }

    private double S()
    {
        return Opseg() / 2;
    }
}