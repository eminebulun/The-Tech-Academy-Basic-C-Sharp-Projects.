using System;

class ShippingApp
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Kargo ağırlığını al
        Console.WriteLine("Please enter the package weight:");
        if (!double.TryParse(Console.ReadLine(), out double kargoAgirlik))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        if (kargoAgirlik > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Genişlik bilgisi alınıyor
        Console.WriteLine("Please enter the package width:");
        if (!double.TryParse(Console.ReadLine(), out double genislik))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Yükseklik bilgisi alınıyor
        Console.WriteLine("Please enter the package height:");
        if (!double.TryParse(Console.ReadLine(), out double yukseklik))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Uzunluk bilgisi alınıyor
        Console.WriteLine("Please enter the package length:");
        if (!double.TryParse(Console.ReadLine(), out double uzunluk))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        double boyutToplam = genislik + yukseklik + uzunluk;

        // Boyut sınırı kontrolü
        if (boyutToplam > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Tahmini kargo fiyatı hesaplanıyor
        double tahminiFiyat = (genislik * yukseklik * uzunluk * kargoAgirlik) / 100;

        Console.WriteLine("Your estimated total for shipping this package is: ${0:0.00}", tahminiFiyat);
        Console.WriteLine("Thank you!");
    }
}
