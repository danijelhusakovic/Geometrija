using System;
public class Program
{
    static void Main(string[] args)
    {
        Tocka a = new Tocka(8f, 2f);
        Tocka b = new Tocka(11f, 13f);
        Tocka c = new Tocka(2f, 6f);

        Duzina duzina = new Duzina(a, b);
        //Console.WriteLine(duzina.Duljina());
        //Console.WriteLine(abc.Opseg());
        //Console.WriteLine(abc.Povrsina());

        //Console.WriteLine(abc.JeJednakostranican());
        //Console.WriteLine(abc.JeJednakokracan());
        //Console.WriteLine(abc.JePravokutan());


        GeometrijskiLik[] likovi = new GeometrijskiLik[2];
        likovi[0] = new Trokut(a, b, c);
        likovi[1] = new Pravokutnik();

        // Primjer polimorfizma.
        // Poziva "Povrsina" svim GEOMETRIJSKIMLIKOVIMA
        // i nije ga briga radi li se o trokutu, pravokutniku
        // ili kružnici.
        // Tkogod nasljeđuje, znamo 100% da je implementirao
        // Povrsina i Opseg funkcije / metode.
        // Možemo se osloniti da ima Povrsina i Opseg kada
        // dizajniramo naš projekt :)
        for(int i = 0; i < 2; i++)
        {
            likovi[i].Povrsina();
        }

        Console.ReadKey();
    }
}