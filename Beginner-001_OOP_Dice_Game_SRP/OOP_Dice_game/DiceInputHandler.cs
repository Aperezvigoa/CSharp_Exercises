public class DiceInputHandler
{
    public int UserInput;
    public int CountOfTries;
    public bool IsValid { get; private set; }

    public bool NumberValidation(Dice dice)
    {
        Console.WriteLine("Enter a number:");
        var userTry = Console.ReadLine();
        IsValid = int.TryParse(userTry, out UserInput);
        if (IsValid && (UserInput > 0 && UserInput <= dice.SidesCount))
        {
            ++CountOfTries;
            return IsValid;
        }
        Console.WriteLine("Invalid Input");
        return IsValid;
    }
}