using System.Linq.Expressions;

public class Program
{
    static void Main(string[] args)
    {
        Trokut abc = new Trokut(new Tocka(), new Tocka(0, 3), new Tocka(4, 0));
        Console.WriteLine(abc.Opseg());
        Console.WriteLine(abc.Povrsina());
        Console.WriteLine(abc.JeJednakostranican());
        Console.WriteLine(abc.JeJednakoKracan());
        Console.WriteLine(abc.JeRaznostranican());
        Console.WriteLine(abc.JePravokutan());

        Kruznica kruznica = new Kruznica(10);
        Console.WriteLine(kruznica.Opseg());
        Console.WriteLine(kruznica.Povrsina());

        Pravokutnik pravokutnik = new Pravokutnik(new Tocka(), new Tocka(5, 0), new Tocka(5, 2), new Tocka(0, 2));
        Console.WriteLine(pravokutnik.Opseg());
        Console.WriteLine(pravokutnik.Povrsina());
        Console.WriteLine(pravokutnik.JeKvadrat());
    }
}