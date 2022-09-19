namespace Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Condition";

            int a = 8;
            int b = 3;

            string verb = (a != 1) ? " are " : " is ";
            Console.Write("There" + verb + a );

            string parity = (a % 2 != 0) ? " Odd" : " Even";
            Console.Write("\n\n" + a + " is " + parity);

            parity = (b % 2 != 0) ? " Odd " : " Even ";
            Console.Write("\n\n" + b + " is " + parity);

            int max = (a > b) ? a : b;
            Console.Write("\n\nMaximum is " + max);
            Console.ReadKey();

        }
    }
}