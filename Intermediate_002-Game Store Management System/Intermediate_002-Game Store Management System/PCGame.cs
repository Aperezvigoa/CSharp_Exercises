using System;

public class PCGame:VideoGame
{
    private string _minimumRequirements;

    public PCGame(string title, double price, int releaseYear, string requirements):base(title, price, releaseYear)
    {
        MinimunRequirements = requirements;
    }

    public string MinimunRequirements
    {
        get => _minimumRequirements;
        set
        {
            if (value == null || value.Trim().Length == 0) _minimumRequirements = "Not aviable";
            else _minimumRequirements = value;
        }
    }

    public override void showDetails()
    {
        Console.WriteLine("=-------------= PC GAME DETAILS =-------------=");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Minimum Requirements: {MinimunRequirements}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Product ID: {GameID}");
    }
}