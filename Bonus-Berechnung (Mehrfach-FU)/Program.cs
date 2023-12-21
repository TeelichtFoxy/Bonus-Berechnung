using System;

public class Program()
{
    public static void Main()
    {
        //Deklarationsblock
        double Umsatz, Bonus;
        //Menu
        Console.Write("\n" +
            "Bonus Rechner\n" +
            "\n" +
            "\n" +
            "Bitte geben Sie den Umsatz ein:\n");
        Umsatz = Convert.ToDouble(Console.ReadLine());
        //0.02
        if (Umsatz >= 50000 && Umsatz <= 100000)
        {
            Bonus = Umsatz * 0.02;
            Console.WriteLine("Der Bonus beträgt: {0}€.", Umsatz, Bonus);
        }
        //0.03
        else if (Umsatz >= 10000 && Umsatz <= 150000)
        {
            Bonus = Umsatz * 0.03;
            Console.WriteLine("Der Bonus beträgt: {0}€.", Umsatz, Bonus);
        }
        //0.04
        else if (Umsatz >= 150000 && Umsatz <= 200000)
        {
            Bonus = Umsatz * 0.04;
            Console.WriteLine("Der Bonus beträgt: {0}€.", Umsatz, Bonus);
        }
        //0.05
        else if (Umsatz >= 200000)
        {
            Bonus = Umsatz * 0.05;
            Console.WriteLine("Der Bonus beträgt: {0}€.", Umsatz, Bonus);
        }
        //0
        else if (Umsatz >= 1)
        {
            Console.WriteLine("Der Bonus beträgt: 0€.");
        }
        else
        {
            Console.WriteLine("Ungültige Angabe!");
        }
    }
}