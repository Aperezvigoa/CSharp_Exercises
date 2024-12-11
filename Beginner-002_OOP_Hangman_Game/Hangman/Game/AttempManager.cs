namespace Hangman.Game;
public class AttempManager
{
    private int _maxAttemps;

    public AttempManager() => _maxAttemps = 5;

    public int RemainingAttempts() => _maxAttemps;

    public int UpdateRemainingAttempts(bool isDuplicateLetter, bool isCharInWord)
    {
        if (!isDuplicateLetter && !isCharInWord) --_maxAttemps;
        return _maxAttemps;
    }
}
