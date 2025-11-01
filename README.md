# C# Palindrome Checker

This project is a simple .NET solution created as part of a C# learning journey. It demonstrates fundamental .NET project structure, unit testing with xUnit, and C# logic using LINQ.

The core of the project is a class library (`PalindromeService`) that contains a single method, `IsPalindrome`, which correctly determines if a given string is a palindrome (reads the same forwards and backwards, ignoring case and non-alphanumeric characters).

## Project Structure

This solution uses a standard, multi-project structure:

* `PalindromeSolution.sln`: The solution file that "contains" and links all the projects.
* `PalindromeService/`: A .NET Class Library project. This is where the application's "business logic" lives. It cannot be run on its own; it's designed to be used by other applications.
    * `StringService.cs`: Contains the `IsPalindrome` method.
* `PalindromeService.Tests/`: An xUnit Test Project. This project references the `PalindromeService` project in order to test its code.
    * `StringServiceTests.cs`: Contains the unit tests to verify that `IsPalindrome` works correctly for both true and false cases.

## Features

The `StringService` class provides the following method:

**`bool IsPalindrome(string input)`**

This method checks if a string is a palindrome. The logic is as follows:

* Returns `true` for any `null` or empty string.
* Converts the input string to lowercase.
* Removes all non-alphanumeric characters (punctuation, spaces, etc.).
* Compares the cleaned string to its reversed version.

## How to Build and Run Tests

This project is built and tested using the .NET CLI.

1.  Clone the repository (or ensure you are in the main `CSharpJourney` folder).
2.  Ensure all dependencies are restored (this happens automatically with most commands, but can be run manually):
    ```bash
    dotnet restore
    ```
3.  Run the unit tests:
    From the root `CSharpJourney` folder (the one containing `PalindromeSolution.sln`), run the following command:
    ```bash
    dotnet test
    ```
You should see an output indicating that all tests have passed successfully.

## Core Concepts Demonstrated

* **.NET Project Structure**: Creating a solution (`.sln`) with multiple projects (`.csproj`).
* **Class Libraries**: Building code into a reusable library.
* **Unit Testing (xUnit)**: Writing tests using the "Arrange, Act, Assert" pattern with `[Fact]`.
* **Test-Driven Development (TDD)**: Writing tests that define the requirements for our code.
* **LINQ (Language-Integrated Query)**: Using `.Where()`, `.Reverse()`, and `.ToArray()` to cleanly and efficiently process strings.
* **C# Fundamentals**: Methods, classes, booleans, and string manipulation.
