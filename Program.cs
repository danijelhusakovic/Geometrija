public class Program
{
    static void Main(string[] args)
    {
        Tocka a = new Tocka(0, 0);
        Tocka b = new Tocka(0, 0);
        Tocka c = new Tocka(0, 0);

        Oblik[] oblici = new Oblik[3];

        oblici[0] = new Trokut(a, b, c);
        oblici[1] = new Kruznica(a, 10);

        // Prikaz itema
        for(int i = 0; i < 2; i++)
        {
            oblici[i].Opseg();
        }
    }
}
