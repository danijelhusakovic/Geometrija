using System;
public class Duzina
{
    public Tocka A;
    public Tocka B;

    public Duzina(Tocka a, Tocka b)
    {
        this.A = a;
        this.B = b;
    }

    public float Duljina()
    {
        float rezultat;

        float x = B.X - A.X;
        float y = B.Y - A.Y;
        
        rezultat = (float) 
            Math.Sqrt(
            Math.Pow(x, 2) + Math.Pow(y, 2)
            );

        return rezultat;
    }
}