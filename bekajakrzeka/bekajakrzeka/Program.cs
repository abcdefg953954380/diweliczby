class Program
{
    static void Main(string[] args)
    {
        wieksza();
    }

    static void wieksza()
    {
        int a;
        int b;

        Podawanie:

        Console.WriteLine("Podaj pierwszą liczbę");
        bool liczba1 = int.TryParse(Console.ReadLine(),out a);

        Console.WriteLine("Podaj drugą liczbę");
        bool liczba2 = int.TryParse(Console.ReadLine(), out b);

        while (liczba1 == false || liczba2 == false)
        {
            Console.WriteLine("Nie podałeś liczby");
            goto Podawanie;
        }

        if (a > b)
        {
            Console.WriteLine("Pierwsza liczba jest większa");
        }
        else if (b > a)
        {
            Console.WriteLine("Druga liczba jest większa");
        }
        else if(a == b)
        {
            Console.WriteLine("Liczby są równe");
        }
    }
}