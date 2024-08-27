using System;
using System.Globalization;
class uri1006
{

    static void Main(string[] args)
    {
        double pesoA = 2.0;
        double pesoB = 3.0;
        double pesoC = 5.0;

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        double MEDIA = ((A * pesoA) + (B * pesoB) + (C * pesoC)) / (pesoA + pesoB + pesoC);

        Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));

    }

}