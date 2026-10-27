public class Trokut : Oblik
{
    public Tocka A;
    public Tocka B;
    public Tocka C;

    public Trokut(Tocka A, Tocka B, Tocka C)
    {
        Pozicija = new Tocka(0, 0);
        this.A = A;
        this.B = B;
        this.C = C;
    }
}