using System;
using System.Globalization;
class uri1008
{

    static void Main(string[] args)
    {

        int NUMERO = int.Parse(Console.ReadLine());
        int HRSTRABALHADAS = int.Parse(Console.ReadLine());
        double VLRHORA = double.Parse(Console.ReadLine());

        double SALARY = HRSTRABALHADAS * VLRHORA;

        Console.WriteLine("NUMBER = " + NUMERO);
        Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));

    }

}