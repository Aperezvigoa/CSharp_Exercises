# Banking Management System

## Overview
This is a console-based Banking Management System implemented in C#. It provides functionalities for creating and managing bank accounts, including savings and checking accounts. The system supports operations such as deposits, withdrawals, applying interest, and viewing account information. The program is structured with a focus on object-oriented principles like inheritance and polymorphism.

## Features

1. **Account Types**:
   - **Checking Account**:
     - Supports overdraft limits.
   - **Savings Account**:
     - Allows applying interest to the balance.

2. **Operations**:
   - Create new accounts. // Using Guid
   - Deposit money into accounts.
   - Withdraw money from checking accounts.
   - Apply interest to savings accounts.
   - View detailed information for all accounts.

3. **User-Friendly Interface**:
   - Console-based menu system for navigating and performing operations.

4. **Data Validation**:
   - Ensures input correctness for amounts, account selection, and operations.

## Technical Details

- **Programming Language**: C#
- **Framework**: .NET Core
- **Key Concepts Used**:
  - Object-Oriented Programming (OOP)
  - Encapsulation
  - Inheritance
  - Polymorphism

## Classes and Structure

1. **CuentaBancaria** (Base Class):
   - Represents a generic bank account with common properties like account number, balance, and account holder.
   - Includes methods for deposit, withdrawal, and displaying account information.

2. **CuentaAhorro** (Savings Account):
   - Inherits from `CuentaBancaria`.
   - Adds interest rate and the ability to apply interest to the account balance.

3. **CuentaCorriente** (Checking Account):
   - Inherits from `CuentaBancaria`.
   - Adds overdraft functionality with validation to prevent exceeding the overdraft limit.

4. **Interfaz** (Interface Class):
   - Handles console-based user interaction, including displaying menus and account details.

5. **ChoiceProcessor**:
   - Processes user input and manages account-related operations based on menu selections.

6. **Program**:
   - Entry point of the application that initializes the system and manages the main loop.

## Example Usage

Upon running the application, the user will be presented with a menu:
```
========= Banking Management System =========
1. Create new account
2. Deposit money
3. Withdraw money (Checking accounts only)
4. View all accounts
5. Apply interest (Savings accounts only)
6. Exit
```
Users can interact with the menu to create accounts, perform transactions, and view account details. Detailed messages guide the user through each operation.

## Future Enhancements

- Add data persistence using file storage (e.g., JSON or XML).
- Implement user authentication for secure account management.
- Extend support for additional account types.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

---

Feel free to contribute to this project or suggest improvements. Happy coding!
