using System;

public abstract class VideoGame:IRentable
{
    private string _title;
    private double _price;
    private int _releaseYear;
    private string _status;
    public string GameID { get; private set; }

    public VideoGame(string title, double price, int releaseYear)
    {
        Title = title;
        Price = price;
        ReleaseYear = releaseYear;
        GameID = Guid.NewGuid().ToString();
        Status = "Avaible";
    }

    public string Title
    {
        get => _title;
        private set
        {
            if (value == null || value.Trim().Length == 0) value = "Unknown";
            else _title = value.Trim();
        }
    }

    public string Status
    {
        get => _status;
        set => _status = value;
    }

    public double Price
    {
        get => _price;
        set
        {
            if (value <= 0) _price = 60;
            else _price = value;
        }
    }

    public int ReleaseYear
    {
        get => _releaseYear;
        set
        {
            if(value < 1980 || value > DateTime.Now.Year) _releaseYear = DateTime.Now.Year;
            else _releaseYear = value;
        }
    }

    public abstract void showDetails();

    public virtual void ApplyDiscount(double percentage)
    {
        Price -= Price * (percentage / 100.0);
    }

    public void Rent()
    {
        if (Status == "Avaible")
        {
            Console.WriteLine("Game rented successfully.");
            Status = "Rented";
        }
        else Console.WriteLine("Game is not avaible.");
    }

    public void Return()
    {
        if(Status == "Rented")
        {
            Console.WriteLine("Game returned successfully.");
            Status = "Avaible";
        }
        else Console.WriteLine("Game is not rented");
    }
}