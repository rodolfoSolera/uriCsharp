using System;
using System.Globalization;
class uri1012
{

    static void Main(string[] args)
    {

        int tempoGasto = int.Parse(Console.ReadLine());
        int velMedia = int.Parse(Console.ReadLine());

        int distanciaPercorrida = tempoGasto * velMedia;

        double qtdLitros = (double) distanciaPercorrida / 12;

        Console.WriteLine(qtdLitros.ToString("F3", CultureInfo.InvariantCulture));

    }

}