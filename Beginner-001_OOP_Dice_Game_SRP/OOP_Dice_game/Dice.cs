public class Dice
{
    public readonly int DiceNumber;
    private int _sidesCount;

    public Dice(int diceFaces)
    {
        Random rnd = new Random();
        SidesCount = diceFaces;
        DiceNumber = rnd.Next(1, _sidesCount);
    }

    public int SidesCount
    {
        get => _sidesCount;
        set
        {
            if (value < 6) _sidesCount = 6;
            else _sidesCount = value;
        }
    }
}
