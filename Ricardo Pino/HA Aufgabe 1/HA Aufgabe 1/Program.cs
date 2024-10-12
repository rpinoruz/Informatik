using System;

namespace HA_Aufgabe_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie einen zahl ein: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben Sie noch ein anderer Zahl ein: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double dif = a - b;

            Console.WriteLine("Die Differenz von den Zahlen ist: " + dif.ToString());
        }
    }
}