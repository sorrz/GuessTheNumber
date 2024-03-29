﻿using System;
using GuessTheNumber.Model;

namespace GuessTheNumber.Data;

public class Game
{
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
        if (numberOfGuesses < 2)
        {
            Console.Write(
                $"A Random Number between 1-100 have been generated,\nplease enter guess no. {numberOfGuesses}: ");
            var userGuess = Console.ReadLine();
            IsNumber(userGuess);
        }
        else
        {
            Console.Write(
                $"Please enter guess no. {numberOfGuesses}: ");
            var userGuess = Console.ReadLine();
            IsNumber(userGuess);
        }
    }

    // Check if the Guess is a Int Number
    private static void IsNumber(string? userGuess)
    {
        var isNumber = int.TryParse(userGuess, out userNumber);
        if (isNumber) 
            CheckNumber(userNumber);
        else
            Console.WriteLine("Sorry, you did not enter a valid integer number, try again");
            Guess();
        
    }

    // Check the Verified INT against the Random Number for Win Conditions
    private static void CheckNumber(int userNumber)
    {
        // Catch Faulty Numbers
        if (userNumber < 1 || userNumber > 100)
        {
            Console.WriteLine("Sorry, you you should guess between 1 and 100");
            Guess();
        }

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

            // Save A highscore if it's lower then the current in list
            var index = 0;
            foreach (var _score in Score.Scores)
            {
                // Check the list and create a new Object to insert at the right Index.
                if (numberOfGuesses < _score.NumberOfGuesses)
                {
                    Console.Write("\n Please Enter your Name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine($"You've gotten placement numer {index + 1}");
                    Score.Scores.Insert(index, new ScoreModel(name, numberOfGuesses));
                    break;
                }

                // Increase the Index to keep tabs on where we are in the list.
                index++;
            }

            Console.WriteLine("Press any key to take you back to the Menu");
            Console.ReadKey(true);
            // Pallet Cleanser
            numberOfGuesses = 1;
            theNumber = rnd.Next(1, 100);
            // Back to Menu
            App.Menu();
        }
    }

    #region Fields

    private static readonly Random rnd = new();
    private static int theNumber = rnd.Next(1, 100);
    private static int userNumber;
    public static int numberOfGuesses = 1;

    #endregion
}