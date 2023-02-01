using System;
namespace uppgift25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv en multiplikation mellan två decimaltal.\n Exempel: 3,6*2,7");
            string multiplikation = Console.ReadLine();
            int multipliktecken = multiplikation.IndexOf("*");
            string faktor1 = multiplikation[..multipliktecken];
            string faktor2 = multiplikation[(multipliktecken+1)..];
            float mathfaktor1 = float.Parse(faktor1);
            float mathfaktor2 = float.Parse(faktor2);   
            Console.WriteLine("svaret på ditt tal är:" + mathfaktor1 * mathfaktor2);
        }
    }
}
