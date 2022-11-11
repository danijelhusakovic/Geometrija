using System;
public class Trokut: GeometrijskiLik
{
    public Tocka A;
    public Tocka B;
    public Tocka C;

    public Duzina AB;
    public Duzina BC;
    public Duzina CA;

    public float S;

    public Trokut(Tocka a, Tocka b, Tocka c)
    {
        this.A = a;
        this.B = b;
        this.C = c;

        AB = new Duzina(a, b);
        BC = new Duzina(b, c);
        CA = new Duzina(c, a);
    }

    public override float Opseg()
    {
        float rezultat;

        rezultat = AB.Duljina() + BC.Duljina() + CA.Duljina();

        return rezultat;
    }

    public override float Povrsina()
    {
        float rezultat;

        S = Opseg() / 2;

        rezultat = S * 
            (S - AB.Duljina()) *
            (S - BC.Duljina()) *
            (S - CA.Duljina());

        rezultat = (float) Math.Sqrt(rezultat);
        return rezultat;
    }

    public bool JePravokutan()
    {
        if (Math.Pow(AB.Duljina(), 2) == 
            Math.Pow(BC.Duljina(), 2) + 
            Math.Pow(CA.Duljina(), 2)) return true;

        if (Math.Pow(CA.Duljina(), 2) == 
            Math.Pow(BC.Duljina(), 2) + 
            Math.Pow(AB.Duljina(), 2)) return true;

        if (Math.Pow(BC.Duljina(), 2) == 
            Math.Pow(CA.Duljina(), 2) + 
            Math.Pow(AB.Duljina(), 2)) return true;

        return false;

    }

    public bool JeJednakokracan()
    {
        if (AB.Duljina().Equals(BC.Duljina())) return true;
        if (BC.Duljina().Equals(CA.Duljina())) return true;
        if (AB.Duljina().Equals(CA.Duljina())) return true;

        return false;
    }

    public bool JeJednakostranican()
    {
        return AB.Duljina().Equals(BC.Duljina()) &&
            BC.Duljina().Equals(CA.Duljina());
    }
}