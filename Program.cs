namespace ChallengeDelegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShowMoney somme1 = SommeDollars;
            Console.WriteLine(somme1(2, 1));

            somme1 = SommeEuros;
            Console.WriteLine(somme1(5, 8));
            
        }
            public delegate string ShowMoney(int x, int y);
            public static string SommeDollars(int x, int y) => $"{(x + y)} $" ;
            public static string SommeEuros(int x, int y) => $"{(x + y)} EUR";

        }
 }

