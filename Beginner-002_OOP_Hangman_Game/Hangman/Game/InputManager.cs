namespace Hangman.Game;
public class InputManager
{
    public List<char> WrongLetters;

    public InputManager()
    {
        WrongLetters = new List<char>();
    }

    public static bool IsValidChar(string input)
    {
        bool InputIsValid = char.TryParse(input, out char inputChar);
        if (InputIsValid)
        {
            if (char.IsLetter(inputChar)) return true;
            return false;
        }
        return false;
    }

    public static char LowChar(char userInput) => char.ToLower(userInput);

    public bool IsCharUsed(char c)
    {
        if (WrongLetters.Contains(c)) return true;
        WrongLetters.Add(c);
        return false;
    }

    public bool IsCharInWord(char userInput, string word)
    {
        foreach (char c in word)
        {
            if (userInput == c) return true;
        }
        return false;
    }
}
