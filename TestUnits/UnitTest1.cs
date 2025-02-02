using Xunit;
using PierwiastkiKwadratowe;

namespace PierwiastkiKwadratowe.Tests
{
    public class TestyRownaniaKwadratowego
    {
        [Theory]
        [InlineData(1, -3, 2, "Dwa pierwiastki rzeczywiste: x1 = 2, x2 = 1")]
        [InlineData(1, 2, 1, "Jeden pierwiastek rzeczywisty: x = -1")]
        [InlineData(1, 0, -4, "Dwa pierwiastki rzeczywiste: x1 = 2, x2 = -2")]
        public void ObliczPierwiastki_ZwracaPoprawnePierwiastki(double a, double b, double c, string oczekiwanyWynik)
        {
            // Act
            string wynik = RozwiazanieRownaniaKwadratowego.ObliczPierwiastki(a, b, c);

            // Assert
            Assert.Equal(oczekiwanyWynik, wynik);
        }

        [Fact]
        public void ObliczPierwiastki_ZwracaBrakPierwiastkowGdyDeltaUjemna()
        {
            // Arrange
            double a = 1, b = 0, c = 4;

            // Act
            string wynik = RozwiazanieRownaniaKwadratowego.ObliczPierwiastki(a, b, c);

            // Assert
            Assert.Equal("Brak rzeczywistych pierwiastków.", wynik);
        }

        [Fact]
        public void ObliczPierwiastki_ZwracaKomunikatGdyNieRownanieKwadratowe()
        {
            // Arrange
            double a = 0, b = 2, c = 3;

            // Act
            string wynik = RozwiazanieRownaniaKwadratowego.ObliczPierwiastki(a, b, c);

            // Assert
            Assert.Equal("To nie jest równanie kwadratowe.", wynik);
        }
    }
}