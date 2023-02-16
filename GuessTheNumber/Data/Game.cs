using System.Numerics;

namespace GuessTheNumber.Data;

public class Game
{
    #region Fields

    private static readonly Random rnd = new();
    private static int theNumber = rnd.Next(1, 100);
    private static int userNumber = 0;
    public static int numberOfGuesses = 1;

    #endregion


    // Initializing Method for each Round
    public static void StartRound()
    {
        // Clean the Screen and start a round of Guesses
        Console.Clear();
        Guess();
    }

    // Starts a Round of Guesses
    private static void Guess()
    {
        // Game Logic Below
        Console.Write(
            $"A Random Number between 1-100 have been generated,\nplease enter guess no. {numberOfGuesses}: ");
        var userGuess = Console.ReadLine();
        IsNumber(userGuess);
    }

    // Check if the Guess is a Int Number
    private static void IsNumber(string? userGuess)
    {
        bool isNumber = int.TryParse(userGuess, out userNumber);
        if (isNumber)
        {
            CheckNumber(userNumber);
        }
        else
        {
            Console.WriteLine("Sorry, you did not enter a valid integer number, try again");
            Guess();
        }
    }

    // Check the Verified INT against the Random Number for Win Conditions
    private static void CheckNumber(int userNumber)
    {
        // Guess is Higher
        if (userNumber > theNumber)
        {
            Console.WriteLine("The number is lower, please try again");
            numberOfGuesses++;
            Guess();
        }

        // Guess in lower
        if (userNumber < theNumber)
        {
            Console.WriteLine("The number is higher, please try again");
            numberOfGuesses++;
            Guess();
        }

        // Guess is a match
        if (userNumber == theNumber)
        {
            Console.Clear();
            Console.WriteLine($"Congratulations, you did it in {numberOfGuesses} guesses.");
            Console.WriteLine("Press any key to take you back to the Menu");
            Console.ReadKey(true);
            // TODO: HighScore Handling

            // Pallet Cleanser
            numberOfGuesses = 1;
            theNumber = rnd.Next(1, 100);
            // Back to Menu
            App.Menu();
        }
    }
}