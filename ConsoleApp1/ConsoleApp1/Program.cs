namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");
        int[] tablica = { 1, 2, 3, 4 };
        Console.WriteLine("Suma tablicy to: " + SumaTablicy(tablica));
        Console.WriteLine("Srednia tablicy to: " + SredniaTablicy(tablica));
        Console.WriteLine("Maks tablicy to: " + MaksTablicy(tablica));

    }
    
    public static int SumaTablicy(int[] tablica)
    {
        int suma = 0;
        foreach (int val in tablica)
        {
            suma += val;
        }

        return suma;
    }
    public static int SredniaTablicy(int[] tablica)
    {
        int suma = SumaTablicy(tablica);
        return suma / tablica.Length;
    }
    public static int MagitksTablicy(int[] tablica)
    {
        int maks = tablica[0];
        foreach (int val in tablica)
        {
            if (val > maks) maks = val;
        }

        return maks;
    }
}