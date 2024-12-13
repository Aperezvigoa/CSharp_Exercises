using System;
using System.Collections.Generic;

public class ChoiceProcessor
{
    public void MainMenu(int choice, List<VideoGame> allGames, List<VideoGame> allRented)
    {
        switch(choice)
        {
            case 1:
                Console.Clear();
                Menu.MainTitle();
                Menu.AddVideogame();
                AddVideoGame(allGames);
                Console.ReadKey();
                Console.Clear();
                break;
            case 2:
                Console.Clear();
                Menu.MainTitle();
                printingAllGames(allGames);
                Console.ReadKey();
                Console.Clear();
                break;
            case 3:
                Console.Clear();
                Menu.MainTitle();
                printingRentedGames(allRented);
                Console.Clear();
                break;
            case 4:
                Console.Clear();
                Menu.MainTitle();
                rentingAGame(allGames, allRented);
                Console.Clear();
                break;
            case 5:
                Console.Clear();
                Menu.MainTitle();
                returningAGame(allGames, allRented);
                Console.Clear();
                break;
            case 6:
                Console.Clear();
                Menu.MainTitle();
                ApplyDiscounts(allGames);
                Console.ReadKey();
                Console.Clear();
                break;
            default:
                Console.Clear();
                break;
        }
    }

    public void AddVideoGame(List<VideoGame> allGames)
    {
        string title = null;
        double price = 0;
        int year = 0;
        switch (SelectChoice())
        {
            case 1:
                requestingBasics(ref title, ref price, ref year);
                Menu.RequestMinimumRequirements();
                string minimumRequirements = Console.ReadLine();
                PCGame pcgame = new PCGame(title, price, year, minimumRequirements);
                allGames.Add(pcgame);
                break;
            case 2:
                requestingBasics(ref title, ref price, ref year);
                Menu.RequestConsoleGame();
                string consoleName = Console.ReadLine();
                ConsoleGame consolegame = new ConsoleGame(title, price, year, consoleName);
                allGames.Add(consolegame);
                break;
            case 3:
                requestingBasics(ref title, ref price, ref year);
                Menu.RequestSizeInMB();
                string strSizeInMB = Console.ReadLine();
                int.TryParse(strSizeInMB, out int sizeInMB);
                MobileGame mobilegame = new MobileGame(title, price, year, sizeInMB);
                allGames.Add(mobilegame);
                break;
            default:
                Console.Clear();
                break;
        }
    }

    public int SelectChoice()
    {
        Menu.RequestChoice();
        string strChoice = Console.ReadLine();
        bool isValid = int.TryParse(strChoice, out int intChoice);
        if (!isValid) return 0;
        else return intChoice;
    }

    public void requestingBasics(ref string title, ref double price, ref int year)
    {
        Menu.RequestTitle();
        title = Console.ReadLine();
        Menu.RequestPrice();
        string strPrice = Console.ReadLine();
        double.TryParse(strPrice, out double doublePrice);
        price = doublePrice;
        Menu.RequestReleaseYear();
        string strYear = Console.ReadLine();
        int.TryParse(strYear, out int intYear);
        year = intYear;
    }

    public void printingAllGames(List<VideoGame> allGames)
    {
        if(allGames.Count > 0)
        {
            Menu.PrintingAllGames();
            foreach (VideoGame game in allGames)
            {
                game.showDetails();
            }
        }
        else
        {
            Menu.NoGamesAvailable();
            Console.ReadKey();
        }
    }

    public void printingRentedGames(List<VideoGame> allRented)
    {
        if (allRented.Count > 0)
        {
            printSimpleInfo(allRented);
        }
        else
        {
            Menu.NoGamesAvailable();
            Console.ReadKey();
        }
    }

    public void printSimpleInfo(List<VideoGame> gameList)
    {
        int iterator = 1;
        foreach (VideoGame game in gameList)
        {
            Console.WriteLine($"{iterator}. {game.Title} - {game.GameID}");
            iterator++;
        }
    }

    public void rentingAGame(List<VideoGame> allGame, List<VideoGame> allRented)
    {
        if (allGame.Count > 0)
        {
            printSimpleInfo(allGame);
            int selectedGame = SelectChoice();
            selectedGame -= 1;
            if (selectedGame >= 0 && selectedGame < allGame.Count)
            {
                allGame[selectedGame].Rent();
                allRented.Add(allGame[selectedGame]);
            }
        }
        else
        {
            Menu.NoGamesAvailable();
            Console.ReadKey();
        }
    }
    public void returningAGame(List<VideoGame> allGame, List<VideoGame> allRented)
    {
        if (allRented.Count > 0)
        {
            printSimpleInfo(allRented);
            int selectedGame = SelectChoice();
            selectedGame -= 1;
            if (selectedGame >= 0 && selectedGame < allRented.Count)
            {
                allRented[selectedGame].Return();
                allRented.RemoveAt(selectedGame);
            }
        }
        else
        {
            Menu.NoGamesAvailable();
            Console.ReadKey();
        }
    }

    public void ApplyDiscounts(List<VideoGame> allGame)
    {
        foreach(VideoGame game in allGame)
        {
            game.ApplyDiscount(5.0);
        }
        Console.WriteLine("Discount applied successfully");
    }
}