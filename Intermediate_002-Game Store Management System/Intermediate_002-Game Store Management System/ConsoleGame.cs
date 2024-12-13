using System;

public class ConsoleGame:VideoGame
{
    private string _consoleName;

    public ConsoleGame(string title, double price, int releaseYear, string consoleName):base(title, price, releaseYear)
    {
        ConsoleName = consoleName;
    }

    public string ConsoleName
    {
        get => _consoleName;
        set
        {
            if (value == null || value.Trim().Length <= 0) _consoleName = "Multiplatform";
            else _consoleName = value.Trim();
        }
    }

    public override void showDetails()
    {
        Console.WriteLine("=-------------= CONSOLE GAME DETAILS =-------------=");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Console: {ConsoleName}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Product ID: {GameID}");
    }
}