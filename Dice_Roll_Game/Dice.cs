
public class Dice
{
    public int Number { get; } 
    public int DiceRoll()
    {
        int _number = new Random().Next(1,7);
        _number = Number;
        return Number;
    }
}
