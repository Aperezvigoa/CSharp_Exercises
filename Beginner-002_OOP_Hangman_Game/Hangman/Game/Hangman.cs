namespace Hangman.Game;
class Hangman
{
    private ExtractingWords extractor;
    private SelectingAWord _selectingWord;
    private WordManager wordManager;
    private InputManager inputManager;
    private AttempManager attempManager;
    private int attemps;
    public readonly string SelectedWord;
    private List<string> words;

    public Hangman()
    {
        extractor = new ExtractingWords();
        words = new List<string>();
        inputManager = new InputManager();
        attempManager = new AttempManager();
        // Reading words and add to list
        words = extractor.ReadWordsFromFile(words);
        // Selecting the random word
        _selectingWord = new SelectingAWord(words);
        // Saving the word
        SelectedWord = _selectingWord.RandomWord;
        // Upload to wordManager
        wordManager = new WordManager(SelectedWord);
        // Setting Max attemps
        attemps = attempManager.RemainingAttempts();
    }

    public void Details()
    {
        Console.WriteLine($"The word is {SelectedWord}");
    }
    public void RunGame()
    {
        UserInterface.StartGame();
        while (attempManager.RemainingAttempts() > 0)
        {
            UserInterface.DisplayGameState(wordManager.UserWord, inputManager.WrongLetters, attemps);
            if (WordManager.WordIsRevealed(wordManager.UserWord, SelectedWord))
            {
                UserInterface.VictoryMessage();
                break;
            }
            string userInput = UserInterface.GetUserInput();
            if (InputManager.IsValidChar(userInput))
            {
                char userCharInput = userInput[0];
                userCharInput = InputManager.LowChar(userCharInput);
                attemps = attempManager.UpdateRemainingAttempts(inputManager.IsCharUsed(userCharInput), inputManager.IsCharInWord(userCharInput, SelectedWord));
                wordManager.RevealingWord(userCharInput);
            }
            else UserInterface.ErrorMessage();
        }
        if (attempManager.RemainingAttempts() == 0)
        {
            UserInterface.HangmanStatus(attemps);
            UserInterface.GameOver(SelectedWord);
        }
    }
}
