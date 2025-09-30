using Die_Class;
namespace Topic_1_6___Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            int bank = 100;
            int choice;
            Console.WriteLine("Welcome to the SCAM Casino!");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What would you like to bet on?");
            Console.WriteLine("Press 1 for Doubles (2x payout)");
            Console.WriteLine("Press 2 for Not Doubles (0.5x payout)");
            Console.WriteLine("Press 3 for Even Sum (1x payout)");
            Console.WriteLine("Press 4 for Odd Sum (1x payout)");
        }
    }
}
