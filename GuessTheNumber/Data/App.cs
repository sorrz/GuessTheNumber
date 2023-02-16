namespace GuessTheNumber.Data;

internal class App
{
    // Startup of App, SplashScreen to Hide the front-loading of HighScores
    internal void Start()
    {
        Console.WriteLine("Welcome to Guess the Number");
        Console.WriteLine("The Trickiest Game of Numbers known to man!");
        Console.WriteLine("Press Any-Key to start the game, good luck");
        Console.ReadKey(true);
        //Preloading HighScores
        Score.LoadScores();
        // Kicking over to Menu
        Menu();
    }

    // Menu to give the player Choices
    internal static void Menu()
    {
        Console.Clear();
        Console.WriteLine("##############-MENU-##############");
        Console.WriteLine();
        Console.WriteLine("1.                 Start New Round");
        Console.WriteLine("2.              Display High-Score");
        Console.WriteLine("Esc                   Exit Program");
        Console.Write("");
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.NumPad1:
            case ConsoleKey.D1:
                Game.StartRound();
                break;
            case ConsoleKey.NumPad2:
            case ConsoleKey.D2:
                Score.ListHistory();
                break;
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
            case ConsoleKey.Enter:
                Menu();
                break;
            default:
                Menu();
                break;
        }
    }
}