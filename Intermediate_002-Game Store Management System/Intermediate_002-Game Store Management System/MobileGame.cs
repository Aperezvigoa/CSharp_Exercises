using System;

public class MobileGame:VideoGame
{
    private int _sizeInMB;

    public MobileGame(string title, double price, int releaseYear, int size):base(title, price, releaseYear)
    {
        SizeInMB = size;
    }

    public int SizeInMB
    {
        get => _sizeInMB;
        set
        {
            if (value <= 0) _sizeInMB = 1024;
            else _sizeInMB = value;
        }
    }

    public override void showDetails()
    {
        Console.WriteLine("=-------------= MOBILE GAME DETAILS =-------------=");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Size in MB: {SizeInMB}Mb");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Product ID: {GameID}");
    }
}