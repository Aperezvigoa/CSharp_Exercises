using System;

Console.WriteLine("Welcome to the TODO List App");
Console.WriteLine("****************************");

bool exitApp = false;
string userOptionInput = "";
List<string> toDoList = new List<string>();
 
do
{
    PrintOptions();
    userOptionInput = ReadAndTrim(userOptionInput);

    bool canParseIt = char.TryParse(userOptionInput, out char userSelection);

    if (!canParseIt)
    {
        Console.WriteLine("\nIncorrect input");
    }
    else
    {
        userSelection = char.ToUpper(userSelection);
        switch (userSelection)
        {
            case 'S':
                if (toDoList.Count <= 0)
                {
                    EmptyList();
                    continue;
                }
                else
                {
                    ShowToDos();
                }
                break;

            case 'A':
                AddToDo();
                break;

            case 'R':
                RemoveAToDo();
                break;
            case 'E':
                exitApp = true;
                break;
            default:
                Console.WriteLine("\nIncorrect input\n");
                continue;
        }
    }


} while (!exitApp);

// Methods
void ShowToDos()
{
    Console.WriteLine("\nTODO List\n---------");
    foreach (string todos in toDoList)
    {
        Console.WriteLine($"{toDoList.IndexOf(todos) + 1}. {todos}");
    }
}

void AddToDo()
{
    bool isAdded = false;

    do
    {
        Console.WriteLine("Enter the TODO description:");
        userOptionInput = ReadAndTrim(userOptionInput);

    } while (!isDescriptionValid(userOptionInput));

    toDoList.Add(userOptionInput);
}

bool isDescriptionValid(string description)
{
    if (userOptionInput == "")
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }
    else if (toDoList.Contains(userOptionInput))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }
    else
    {
        Console.WriteLine($"TODO successfully added: {userOptionInput}");
        return true;
    }
}

void RemoveAToDo()
{
    bool correctIndex = false;
    while (!correctIndex)
    {
        if (toDoList.Count == 0)
        {
            EmptyList();
            correctIndex = true;
            break;
        }

        Console.WriteLine("Select the index of the TODO you want to remove:");
        ShowToDos();
        userOptionInput = ReadAndTrim(userOptionInput);
        bool indexCheck = int.TryParse(userOptionInput, out int indexToRemove);

        if (!indexCheck || (indexToRemove - 1) < 0 || (indexToRemove - 1) > (toDoList.Count - 1))
        {
            Console.WriteLine("Please enter a valid number corresponding to a TODO item.");
            continue;
        }
        else
        {
            Console.WriteLine($"TODO removed: {toDoList[indexToRemove - 1]}");
            toDoList.Remove(toDoList[indexToRemove - 1]);
            correctIndex = true;
        }

    }
}

void EmptyList() { Console.WriteLine("\nNo TODOs have been added yet!\n"); }

void PrintOptions()
{
    Console.WriteLine("\nWhat do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit\n");
}

string ReadAndTrim(string userInput)
{
    userInput = Console.ReadLine();
    return userInput.Trim();
}
