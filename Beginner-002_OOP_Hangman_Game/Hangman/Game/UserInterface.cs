namespace Hangman.Game;
public static class UserInterface
{

    public static void StartGame()
    {
        Console.WriteLine(" ___  ___  ________  ________   ________  _____ ______   ________  ________      ");
        Console.WriteLine("|\\  \\|\\  \\|\\   __  \\|\\   ___  \\|\\   ____\\|\\   _ \\  _   \\|\\   __  \\|\\   ___  \\    ");
        Console.WriteLine("\\ \\  \\\\\\  \\ \\  \\|\\  \\ \\  \\\\ \\  \\ \\  \\___|\\ \\  \\\\\\__\\ \\  \\ \\  \\|\\  \\ \\  \\\\ \\  \\   ");
        Console.WriteLine(" \\ \\   __  \\ \\   __  \\ \\  \\\\ \\  \\ \\  \\  __\\ \\  \\\\|__| \\  \\ \\   __  \\ \\  \\\\ \\  \\  ");
        Console.WriteLine("  \\ \\  \\ \\  \\ \\  \\ \\  \\ \\  \\\\ \\  \\ \\  \\|\\  \\ \\  \\    \\ \\  \\ \\  \\ \\  \\ \\  \\\\ \\  \\ ");
        Console.WriteLine("   \\ \\__\\ \\__\\ \\__\\ \\__\\ \\__\\\\ \\__\\ \\_______\\ \\__\\    \\ \\__\\ \\__\\ \\__\\ \\__\\\\ \\__\\");
        Console.WriteLine("    \\|__|\\|__|\\|__|\\|__|\\|__| \\|__|\\|_______|\\|__|     \\|__|\\|__|\\|__|\\|__| \\|__|");
        Console.WriteLine("                                                          Developed by Aperezvigoa\n\n\n");
    }
    public static void DisplayGameState(string userWord, List<char> wrongLetters, int attemptsRemaining)
    {
        Console.WriteLine($"\nUsed Letters: {string.Join(",", wrongLetters)}");
        Console.WriteLine($"\nRemaining Attemps: {attemptsRemaining}\n");
        HangmanStatus(attemptsRemaining);
        Console.WriteLine($"Word Status: {userWord}");
    }

    public static string GetUserInput()
    {
        Console.Write("Enter a letter: ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    public static void ErrorMessage() => Console.WriteLine("\nInvalid Input!\n");

    public static void VictoryMessage() => Console.WriteLine("\nYou win!\n");

    public static void GameOver(string word) => Console.WriteLine($"\nGame Over! The word was {word}...\n");

    public static void HangmanStatus(int attemptsRemaining)
    {
        switch (attemptsRemaining)
        {
            case 5:
                Console.WriteLine(" ____");
                Console.WriteLine("|/   |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|_____\n");
                break;
            case 4:
                Console.WriteLine(" ____");
                Console.WriteLine("|/   |");
                Console.WriteLine("|   (_)");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|_____\n");
                break;
            case 3:
                Console.WriteLine(" ____");
                Console.WriteLine("|/   |");
                Console.WriteLine("|   (_)");
                Console.WriteLine("|    |");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|_____\n");
                break;
            case 2:
                Console.WriteLine(" ____");
                Console.WriteLine("|/   |");
                Console.WriteLine("|   (_)");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|_____\n");
                break;
            case 1:
                Console.WriteLine(" ____");
                Console.WriteLine("|/   |");
                Console.WriteLine("|   (_)");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|    |");
                Console.WriteLine("|   /");
                Console.WriteLine("|");
                Console.WriteLine("|_____\n");
                break;
            case 0:
                Console.WriteLine(" ____");
                Console.WriteLine("|/   |");
                Console.WriteLine("|   (_)");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|    |");
                Console.WriteLine("|   / \\");
                Console.WriteLine("|");
                Console.WriteLine("|_____\n");
                break;
            default:
                Console.WriteLine("Unexpected error ocurred.");
                break;
        }
    }
}