# TODO List App in C#

A simple console-based TODO List application written in C#. This program allows users to manage their tasks interactively through a command-line interface.

---

## Features

- **View Tasks**  
  Display all current tasks in the TODO list in a clear and numbered format.

- **Add Tasks**  
  Add new tasks with unique, non-empty descriptions. Duplicate entries are not allowed.

- **Remove Tasks**  
  Remove tasks from the list by specifying their index.

- **Exit Application**  
  Close the program at any time.

---

## How It Works

1. When the app starts, it displays a menu with the following options:
   - `[S]`ee all TODOs
   - `[A]`dd a TODO
   - `[R]`emove a TODO
   - `[E]`xit

2. Users can select an option by entering the corresponding letter.

3. The program validates user input and performs the requested action.

4. Task management is dynamic, and the list updates automatically after each operation.


This project is perfect for beginners in C# who want to learn about loops, conditionals, collections (List<T>), and input handling in console applications.

Feel free to clone the repository and enhance the functionality! 😉

---

## Example Usage

```plaintext
Welcome to the TODO List App
****************************

What do you want to do?
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit

> A
Enter the TODO description:
> Buy groceries
TODO successfully added: Buy groceries

> S
TODO List
---------
1. Buy groceries

> R
Select the index of the TODO you want to remove:
1. Buy groceries
> 1
TODO removed: Buy groceries

> E
Goodbye!




