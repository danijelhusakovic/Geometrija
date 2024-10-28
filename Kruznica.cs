public class Kruznica : GeometrijskiLik
{
    public double r;

    /// <summary>
    /// A circle. Receives the radius.
    /// </summary>
    /// <param name="r">Radius of the circle</param>
    public Kruznica(double r)
    {
        this.r = r;
    }

    /// <summary>
    /// Calculates the extent of the circle
    /// </summary>
    /// <returns></returns>
    public override double Opseg()
    {
        return 2 * r * Math.PI;
    }

    /// <summary>
    /// Calculates the area of the circle
    /// </summary>
    /// <returns></returns>
    public override double Povrsina()
    {
        return Math.Pow(r, 2) * Math.PI;
    }
}