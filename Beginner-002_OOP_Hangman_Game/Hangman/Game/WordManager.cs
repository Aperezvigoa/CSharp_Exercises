namespace Hangman.Game;
public class WordManager
{
    public readonly string SecretWord;
    public string UserWord = "";

    public WordManager(string SelectedWord)
    {
        SecretWord = SelectedWord;
        foreach (char c in SecretWord) UserWord += '-';
    }

    public string RevealingWord(char userInputChar)
    {
        List<int> positions = new List<int>();


        for (int i = 0; i < SecretWord.Length; i++)
        {
            if (SecretWord[i] == userInputChar) positions.Add(i);
        }

        char[] tempWordArr = UserWord.ToCharArray();

        if (positions.Count > 0)
        {
            for (int i = 0; i < positions.Count; i++)
            {
                tempWordArr[positions[i]] = userInputChar;
            }
            UserWord = new string(tempWordArr);
        }
        return UserWord;
    }

    public static bool WordIsRevealed(string userWord, string secretWord)
    {
        if (userWord == secretWord) return true;
        return false;
    }
}
