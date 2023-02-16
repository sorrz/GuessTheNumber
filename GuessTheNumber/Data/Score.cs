namespace GuessTheNumber.Data;

public class Score
{
    public Score()
    {
    }

    #region Fields

    private string name { get; set; }
    private int numberOfGuesses { get; set; }
    private DateTime whenScored { get; set; }
    private static List<Score> Scores = new();

    private static readonly string filePath =
        @"C:\Users\danst\source\repos\GuessTheNumber\GuessTheNumber\HighScore\highscore.txt";

    private static Score _score;

    #endregion

    // Function for listing all the Objects in the Score List
    public static void ListHistory()
    {
        // Clear and List all Object-contents per Object
        Console.Clear();
        var i = 1;
        foreach (var _score in Scores)
        {
            Console.WriteLine(
                $"{i} Held by:  {_score.name} with {_score.numberOfGuesses} done at {_score.whenScored} ");
            i++;
        }

        // Back to Menu on User Input
        Console.WriteLine("\n \n Press Any-Key to get back to the Menu");
        Console.ReadKey(true);
        App.Menu();
    }

    // Function used for pre-loading the highscore file into a list of Objects.
    public static void LoadScores()
    {
        var fileLines = File.ReadLines(filePath);
        foreach (var line in fileLines)
        {
            // // DEBUGGING ONLY _ REMOVE ME
            // Console.WriteLine(line);
            //
            // Divide the line
            var data = line.Replace("  ", string.Empty).Replace("\t", string.Empty).Split(' ');
            _score = new Score
            {
                name = data[0],
                numberOfGuesses = Convert.ToInt32(data[1]),
                whenScored = Convert.ToDateTime(data[2])
            };
            Scores.Add(_score);
        }
    }
}