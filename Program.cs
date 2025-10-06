using Die_Class;
using System.Diagnostics;
using System.Diagnostics.Metrics;
namespace Topic_1_6___Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die(ConsoleColor.Green);
            Die die2 = new Die(ConsoleColor.Green);
            double bank = 100;
            double bet;
            string choice = "";
            bool done = false;
            Console.WriteLine("Welcome to the SCAM Casino!");
            Console.WriteLine("Hit ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            while (!done)
            {
                Console.Clear();
                Console.WriteLine("What would you like to bet on?");
                Console.WriteLine("Press 1 for Doubles (4x payout)");
                Console.WriteLine("Press 2 for Not Doubles (0.1x payout)");
                Console.WriteLine("Press 3 for Even Sum (1x payout)");
                Console.WriteLine("Press 4 for Odd Sum (1x payout)");
                Console.WriteLine("Press Q to Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.Clear();
                if (bank == 0)
                {
                    Console.WriteLine("You are out of Tokens...");
                    Console.WriteLine("Hit ENTER to continue...");
                    Console.ReadLine();
                    done = true;
                }
                else if (choice == "1")
                {
                    Console.WriteLine("You chose Doubles");
                    Console.WriteLine($"You have {Math.Round(bank, 0)} Tokens");
                    Console.WriteLine("How much would you like to bet?");
                    while(!Double.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > bank)
                    {
                        Console.WriteLine("That is an invalid input... Try Again");
                    }
                    die1.RollDie();
                    die2.RollDie();
                    die1.DrawRoll();
                    die2.DrawRoll();
                    if (die1.Roll == die2.Roll)
                    {
                        Console.WriteLine("DOUBLES! YOU WIN!");
                        bank = bank + (4 * bet);
                    }
                    else
                    {
                        Console.WriteLine($"Not doubles... you lose {bet} Tokens");
                        bank = bank - bet;
                    }
                    Console.WriteLine($"You have {Math.Round(bank, 0)} Tokens");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose Not Doubles");
                    Console.WriteLine($"You have {Math.Round(bank, 0)} Tokens");
                    Console.WriteLine($"The bet must be at least 10 Tokens, or you wont recieve the propper Token payout");
                    Console.WriteLine("How much would you like to bet?");
                    while (!Double.TryParse(Console.ReadLine(), out bet) || bet < 10 || bet > bank)
                    {
                        Console.WriteLine("That is an invalid input... Try Again");
                    }
                    die1.RollDie();
                    die2.RollDie();
                    die1.DrawRoll();
                    die2.DrawRoll();
                    if (die1.Roll != die2.Roll)
                    {
                        Console.WriteLine("NOT DOUBLES! YOU WIN!");
                        bank = bank + (bet / 10);
                    }
                    else
                    {
                        Console.WriteLine($"Doubles... you lose {bet} Tokens");
                        bank = bank - bet;
                    }
                    Console.WriteLine($"You have {Math.Round(bank, 0)} Tokens");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You chose Even Sum");
                    Console.WriteLine($"You have {Math.Round(bank, 0)} Tokens");
                    Console.WriteLine("How much would you like to bet?");
                    while (!Double.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > bank)
                    {
                        Console.WriteLine("That is an invalid input... Try Again");
                    }
                    die1.RollDie();
                    die2.RollDie();
                    die1.DrawRoll();
                    die2.DrawRoll();
                    if (die1.Roll + die2.Roll == 2 || die1.Roll + die2.Roll == 4 || die1.Roll + die2.Roll == 6 || die1.Roll + die2.Roll == 8 || die1.Roll + die2.Roll == 10 || die1.Roll + die2.Roll == 12)
                    {
                        Console.WriteLine("EVEN SUM! YOU WIN!");
                        bank = bank + (bet);
                    }
                    else
                    {
                        Console.WriteLine($"Odd sum... you lose {bet} Tokens");
                        bank = bank - bet;
                    }
                    Console.WriteLine($"You have {Math.Round(bank, 0)} Tokens");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("You chose Odd Sum");
                    Console.WriteLine($"You have {Math.Round(bank, 0)} Tokens");
                    Console.WriteLine("How much would you like to bet?");
                    while (!Double.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > bank)
                    {
                        Console.WriteLine("That is an invalid input... Try Again");
                    }
                    die1.RollDie();
                    die2.RollDie();
                    die1.DrawRoll();
                    die2.DrawRoll();
                    if (die1.Roll + die2.Roll == 3 || die1.Roll + die2.Roll == 5 || die1.Roll + die2.Roll == 7 || die1.Roll + die2.Roll == 9 || die1.Roll + die2.Roll == 11)
                    {
                        Console.WriteLine("ODD SUM! YOU WIN!");
                        bank = bank + (bet);
                    }
                    else
                    {
                        Console.WriteLine($"Even sum... you lose {bet} Tokens");
                        bank = bank - bet;
                    }
                    Console.WriteLine($"You have {Math.Round(bank, 0)} Tokens");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "q")
                {
                    Console.WriteLine("Thanks for playing!");
                    done = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
            if (bank > 100)
            {
                if (bank == 101)
                {
                    Console.WriteLine("You made 1 Token");
                }
                else 
                    Console.WriteLine($"You made {(Math.Round(bank, 0) - 100)} Tokens");
            }
            else if (bank < 100)
            {
                if (bank == 99)
                {
                    Console.WriteLine("You lost 1 Token");
                }
                else 
                    Console.WriteLine($"You lost {(100 - Math.Round(bank, 0))} Tokens");
            }
            else
            {
                Console.WriteLine("You broke even");
            }
        }
    }
}
