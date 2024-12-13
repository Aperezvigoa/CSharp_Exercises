# Video Game Rental System

A comprehensive **Video Game Rental System** written in C#, designed to manage a library of video games across different platforms (PC, Console, Mobile). This project demonstrates key Object-Oriented Programming (OOP) principles, such as abstraction, inheritance, polymorphism, and interface implementation, while maintaining clean code architecture and adhering to the Single Responsibility Principle (SRP).

## Features

- **Add Video Games:**
  - PC games with minimum system requirements.
  - Console games with console-specific details.
  - Mobile games with size in MB.

- **List Video Games:**
  - View all available video games.
  - View rented video games.

- **Rent and Return Games:**
  - Rent a video game and update its status.
  - Return a rented video game to make it available again.

- **Apply Discounts:**
  - Apply a global discount to all video games in the system.

- **Robust Input Validation:**
  - Handles invalid inputs gracefully.

- **Dynamic Unique Identification:**
  - Assigns a unique ID to each game using GUID.

## Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Core

## Project Structure

```
VideoGameRentalSystem/
├── Program.cs               # Entry point of the application
├── VideoGame.cs             # Abstract base class for all video games
├── PCGame.cs                # Class for PC-specific games
├── ConsoleGame.cs           # Class for console-specific games
├── MobileGame.cs            # Class for mobile-specific games
├── IRentable.cs             # Interface for rental functionality
├── Menu.cs                  # Static class for user interaction
├── ChoiceProcessor.cs       # Class to handle menu choices and operations
└── README.md                # Project documentation
```

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/Aperezvigoa/VideoGameRentalSystem.git
   ```

2. Open the project in your favorite C# IDE (e.g., Visual Studio, Rider, Visual Studio Code).

3. Build the solution to restore dependencies.

4. Run the application.

## Usage

1. Launch the application.

2. Navigate the menu:

   ```plaintext
      ____    _    __  __ _____   ____ _____ ___  ____  
     / ___|  / \  |  \/  | ____| / ___|_   _/ _ \|  _ \ 
    | |  _  / _ \ | |\/| |  _|   \___ \ | || | | | |_) |
    | |_| |/ ___ \| |  | | |___   ___) || || |_| |  __/ 
     \____/_/   \_\_|  |_|_____| |____/ |_| \___/|_|    

   1. Add A VideoGame
   2. List Available VideoGames
   3. List Rented VideoGames
   4. Rent A VideoGame
   5. Return A VideoGame
   6. Apply A Global Discount

   Please, Select a choice: _
   ```

3. Follow on-screen prompts to interact with the system.

## Example Interaction

Here is an example interaction with the application:

```plaintext
1. Add A VideoGame
2. List Available VideoGames
3. List Rented VideoGames
4. Rent A VideoGame
5. Return A VideoGame
6. Apply A Global Discount

Please, Select a choice: 1

> Enter the type of game (PC/Console/Mobile): PC
> Enter the name of the game: Cyberpunk 2077
> Enter the minimum system requirements: GTX 1060, 8GB RAM, Intel i5-3570K
Game successfully added!
```

## Contributing

Contributions are welcome! If you find a bug or have a feature request, feel free to open an issue or submit a pull request.

### Steps to Contribute:

1. Fork the repository.
2. Create a new branch (`feature/my-feature` or `bugfix/my-bugfix`).
3. Commit your changes.
4. Push to your branch.
5. Open a pull request.
---
