public class DiceGame
{
    private Dice dice;
    private Tries tries;

    public DiceGame(int maxTries)
    {
        dice = new Dice();
        tries = new Tries(maxTries);
    }
    public void PlayGame()
    {
        Console.WriteLine("Welcome to the Dice Rolling Guessing Game!");
        Console.WriteLine($"The dice have been rolled. You have {tries.GetTries()} to guess the number.");
        int actuallRoll = dice.Roll();
        
        while (tries.GetTries() > 0)
        {
            Console.WriteLine("Enter your guess from 1 to 6: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userGuess) && userGuess >= 1 && userGuess <= 6)
            {
                if (userGuess == actuallRoll)
                {
                    Console.WriteLine("Congratulations you win!");
                    break;
                }
                else
                {
                    tries.LoseTry();
                    Console.WriteLine($"Your guess is incorrect. Try again! {tries.GetTries()} tries left!");
                }

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
            }
        }
        if (tries.GetTries() == 0)
        {
            Console.WriteLine("Sorry, you have run out of tries");
        }
    }

}

