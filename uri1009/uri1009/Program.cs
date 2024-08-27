using System;
using System.Globalization;
class uri1009
{

    static void Main(string[] args)
    {

        string[] produto1 = Console.ReadLine().Split(' ');
        string[] produto2 = Console.ReadLine().Split(' ');

        int QTDP1 = int.Parse(produto1[1]);
        double VLRP1 = double.Parse(produto1[2]);
        double TOTALP1 = QTDP1 * VLRP1;

        int QTDP2 = int.Parse(produto2[1]);
        double VLRP2 = double.Parse(produto2[2]);
        double TOTALP2 = QTDP2 * VLRP2;

        double VLRTOTAL = TOTALP1 + TOTALP2;

        Console.WriteLine("VALOR A PAGAR: R$ " + VLRTOTAL.ToString("F2", CultureInfo.InvariantCulture));

    }

}