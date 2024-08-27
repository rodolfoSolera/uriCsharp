using System;
using System.Globalization;
class uri1010
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double totalPercorrido = x / y;

        Console.WriteLine(totalPercorrido.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

    }

}