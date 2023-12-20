public class Tries
{
    private int maxTries;
    public int remainingTries;

    public Tries(int maxTries)
    {
        this.maxTries = maxTries;
        remainingTries = maxTries;
    }
    public int LoseTry() => remainingTries--;

    public int GetTries() => remainingTries;
}