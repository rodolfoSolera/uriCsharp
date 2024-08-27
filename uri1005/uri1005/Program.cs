using System;
using System.Globalization;
class uri1005
{

    static void Main(string[] args)
    {
        double pesoA = 3.5;
        double pesoB = 7.5;

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        double MEDIA = ((A * pesoA) + (B * pesoB)) / (pesoA + pesoB);

        Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));

    }

}