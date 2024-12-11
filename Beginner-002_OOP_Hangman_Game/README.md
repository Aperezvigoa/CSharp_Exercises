# 🎮 Hangman Game

Welcome to the **Hangman Game** project! This project is a console-based implementation of the classic word-guessing game. It's designed for educational purposes, showcasing principles of object-oriented programming (OOP) and clean code practices.

## 📖 Overview

The Hangman Game allows players to guess letters to uncover a hidden word, with a limited number of attempts. It's a great example of how to break down a larger application into smaller, reusable components.

## 🛠 Features

- **Random Word Selection**: Words are randomly chosen from an external file.
- **Dynamic Game State**: Tracks user guesses, displays the current state of the word, and shows the remaining attempts.
- **Customizable Attempts**: Change the maximum number of attempts easily.
- **ASCII Art**: Visual representation of the hangman as the game progresses.
- **Clean and Modular Design**: Built with multiple classes, each with a specific responsibility.

## 📂 Project Structure

```plaintext
Hangman/
├── Game/
│   ├── AttempManager.cs          # Manages remaining attempts
│   ├── ExtractingWords.cs        # Reads words from a file
│   ├── Hangman.cs                # Core game logic
│   ├── InputManager.cs           # Validates and tracks user input
│   ├── SelectingAWord.cs         # Selects a random word
│   ├── UserInterface.cs          # Handles game UI and messages
│   └── WordManager.cs            # Manages the secret word and revealed letters
├── Program.cs                    # Entry point of the application
└── Hangman.csproj                # Project configuration file


⚠ PLEASE, SAVE "HangmanWords.txt" IN YOUR DESKTOP OR MODIFY THE PATH!!!! ⚠
