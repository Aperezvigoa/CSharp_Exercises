public class PlayerState
{
    public bool GameEnd { get; private set; }
    public bool PlayerWins { get; private set; }

    public const int MaxTries = 3;

    public void PlayerCondition(Dice GeneratedDiceNumber, DiceInputHandler ActualUserInput)
    {
        if (GeneratedDiceNumber.DiceNumber == ActualUserInput.UserInput)
        {
            GameEnd = true;
            PlayerWins = true;
            Console.WriteLine("You win!");
        } else if (ActualUserInput.CountOfTries == MaxTries)
        {
            GameEnd = true;
            PlayerWins = false;
            Console.WriteLine($"You lose!, the number was {GeneratedDiceNumber.DiceNumber}");
        }
        else
        {
            Console.WriteLine("Wrong number");
        }
    }
}