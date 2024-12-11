
markdown
Copiar código
# **Dice Guessing Game** 🎲  

## **Overview**
This project is a simple console-based game developed in C#. It challenges the player to guess the number rolled on a dice within a limited number of attempts. The project demonstrates the application of Object-Oriented Programming (OOP) principles such as modularity, single responsibility, and input validation. It serves as a foundational example for building scalable and maintainable software.

---

## **Features**
- **Configurable Dice:** Supports dice with customizable numbers of faces.
- **Input Validation:** Ensures that user inputs are valid numbers within the expected range.
- **Clear Game Flow:** Displays dynamic feedback to the player, including attempts remaining, success, and failure messages.
- **Separation of Concerns:** Cleanly separates logic for dice rolling, user input handling, game rules, and player state management.

---

## **Technologies**
- Language: **C#**
- Framework: **.NET Core**

---

## **Principles Applied**
- **Single Responsibility Principle (SRP):** Each class has a well-defined responsibility.
- **Modularity:** The project is divided into distinct classes (`Dice`, `UserInputHandler`, `GamePlayer`, `DiceGame`) for improved readability and maintainability.
- **Input Validation:** Handles both invalid and out-of-range inputs gracefully.
