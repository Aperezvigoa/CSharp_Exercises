using System;
using System.Security.Cryptography;

public static class Menu
{
    public static void MainMenu()
    {
        Menu.MainTitle();
        Console.WriteLine("1. Add A VideoGame");
        Console.WriteLine("2. List Aviable VideoGames");
        Console.WriteLine("3. List Rented VideoGames");
        Console.WriteLine("4. Rent A VideoGame");
        Console.WriteLine("5. Return A VideoGame");
        Console.WriteLine("6. Apply A Global Discount");
    }

    public static void MainTitle()
    {
        Console.WriteLine("   ____    _    __  __ _____   ____ _____ ___  ____  ");
        Console.WriteLine("  / ___|  / \\  |  \\/  | ____| / ___|_   _/ _ \\|  _ \\ ");
        Console.WriteLine(" | |  _  / _ \\ | |\\/| |  _|   \\___ \\ | || | | | |_) |");
        Console.WriteLine(" | |_| |/ ___ \\| |  | | |___   ___) || || |_| |  __/ ");
        Console.WriteLine("  \\____/_/   \\_\\_|  |_|_____| |____/ |_| \\___/|_|    ");
        Console.WriteLine();
    }

    public static void AddVideogame()
    {
        Console.WriteLine("=-------------= SELECT THE PLATFORM =-------------=");
        Console.WriteLine("1. Add PC Game");
        Console.WriteLine("2. Add Console Game");
        Console.WriteLine("3. Add Mobile Game");
    }

    public static void RequestTitle() => Console.Write("Enter the title: ");
    public static void RequestPrice() => Console.Write("Enter the price: ");
    public static void RequestReleaseYear() => Console.Write("Enter the release year: ");
    public static void RequestMinimumRequirements() => Console.Write("Enter the minimum requirements: ");
    public static void RequestConsoleGame() => Console.Write("Enter the console name / Enter for multiplatform: ");
    public static void RequestSizeInMB() => Console.Write("Enter the size in MB: ");
    public static void PrintingAllGames() => Console.WriteLine("Current Games in Store:\n");
    public static void NoGamesAvailable() => Console.WriteLine("       ¯\\_(-.-)_/¯\nThere are not games here...");


    public static void RequestChoice()
    {
        Console.Write("Please, Select a choice: ");
    }
}