namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The player", Cash = 100 };

            Console.WriteLine("Welcome to the casino. The odds are " + odds);
            while (true)
            {
                player.WriteMyInfo();
                if (player.Cash == 0)
                {
                    Console.WriteLine("House always wins.");
                    return;
                }

                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                
                if (int.TryParse(howMuch, out int bet))
                {
                    int pot = bet * 2;
                    if (random.NextDouble() > odds)
                    {
                        player.RecieveCash(pot);
                        Console.WriteLine("You win " + pot);
                    }
                    else
                    {
                        player.GiveCash(bet);
                        Console.WriteLine("Bad luck, you lose.");
                    }

                }
            }
            
        }
    }
}