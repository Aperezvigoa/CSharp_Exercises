namespace Hangman.Game;
public class SelectingAWord
{
    public readonly string RandomWord;

    public SelectingAWord(List<string> words)
    {
        var random = new Random();
        RandomWord = words[random.Next(0, words.Count)];
    }
}
