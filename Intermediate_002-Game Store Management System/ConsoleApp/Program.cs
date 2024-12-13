using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<VideoGame> allGames = new List<VideoGame>();
        List<VideoGame> allRented = new List<VideoGame>();
        ChoiceProcessor processor = new ChoiceProcessor();
        while (true)
        {
            Menu.MainMenu();
            processor.MainMenu(processor.SelectChoice(), allGames, allRented);
            Console.Clear();
        }
    }
}