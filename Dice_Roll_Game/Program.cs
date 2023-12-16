var dice = new Dice();
var result = dice.DiceRoll();
var triesLeft = new Tries();
Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries");
Console.ReadKey();

public class Tries
{
    public int tries = 3;
    public int TryLost()
    {
        return tries--;
    }
}