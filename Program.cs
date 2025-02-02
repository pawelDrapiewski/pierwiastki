using System;

namespace PierwiastkiKwadratowe
{
    public static class RozwiazanieRownaniaKwadratowego
    {
        public static string ObliczPierwiastki(double a, double b, double c)
        {
            if (a == 0)
            {
                return "To nie jest równanie kwadratowe.";
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
                return "Brak rzeczywistych pierwiastków.";
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"Jeden pierwiastek rzeczywisty: x = {x}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"Dwa pierwiastki rzeczywiste: x1 = {Math.Round(x1, 2)}, x2 = {Math.Round(x2, 2)}";
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Podaj współczynnik a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            string wynik = ObliczPierwiastki(a, b, c);
            Console.WriteLine(wynik);
        }
    }
}