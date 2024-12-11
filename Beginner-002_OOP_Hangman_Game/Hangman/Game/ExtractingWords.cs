namespace Hangman.Game;
public class ExtractingWords
{
    private StreamReader _sReader;
    private string _lineToRead;
    private readonly string _filePath;

    public ExtractingWords(string path = "C:\\Users\\@YOURNAME\\Desktop\\HangmanWords.txt")
    {
        _filePath = path;
        _sReader = new StreamReader(_filePath);
    }

    public List<string> ReadWordsFromFile(List<string> words)
    {
        _lineToRead = _sReader.ReadLine();
        while (_lineToRead != null)
        {
            words.Add(_lineToRead.Trim());
            _lineToRead = _sReader.ReadLine();
        }
        _sReader.Close();
        return words;
    }
}
