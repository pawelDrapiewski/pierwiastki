using System;

class QuadraticEquationSolver
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj współczynniki równania kwadratowego ax^2 + bx + c = 0:");

        // Pobranie współczynników od użytkownika
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Wywołanie metody do obliczenia pierwiastków
        SolveQuadratic(a, b, c);
    }

    static void SolveQuadratic(double a, double b, double c)
    {
        // Sprawdzenie, czy równanie rzeczywiście jest kwadratowe
        if (a == 0)
        {
            Console.WriteLine("To nie jest równanie kwadratowe.");
            return;
        }

        // Obliczenie delty
        double delta = b * b - 4 * a * c;
        Console.WriteLine($"\nDelta wynosi: {delta}");

        if (delta > 0)
        {
            // Dwa różne pierwiastki rzeczywiste
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Równanie ma dwa pierwiastki rzeczywiste: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            // Jeden pierwiastek podwójny
            double x = -b / (2 * a);
            Console.WriteLine($"Równanie ma jeden pierwiastek podwójny: x = {x}");
        }
        else
        {
            // Brak pierwiastków rzeczywistych
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }
    }
}