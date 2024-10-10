using System;

namespace Das_erste_programm
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Geben Sie bitte drei im Grad Winkeln ein: ");

            double[] Winkeln = new double[3];

            for (int i = 0; i < 3; i++) 
            {
                Winkeln[i] = Convert.ToDouble(Console.ReadLine());
                if ((Winkeln[i] < 0) || (Winkeln[i] > 360))
                {
                    Console.WriteLine("Die gegebene Winkel ist falsch...");
                    System.Environment.Exit(1);
                }

            }

            double[] Sinusse = new double[3];
            double[] Kosinusse = new double[3];

            for (int i = 0; i < 3; i++)
            {
                double WinkelR = (Math.PI / 180) * Winkeln[i];
                Sinusse[i] = Math.Sin(WinkelR);
                Kosinusse[i] = Math.Cos(WinkelR);
            }
            
            for (int i = 0 ;  i < 3; i++)
            {
                Console.WriteLine("Der Winkel " + Winkeln[i] + "° hat der Sinus " + Sinusse[i].ToString() + " und der Kosinus " + Kosinusse[i].ToString());
            }
    
            Console.ReadLine();

        }
    }
}
