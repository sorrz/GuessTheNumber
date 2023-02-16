using System.Text;
using System.Text.Json;
using GuessTheNumber.Model;

namespace GuessTheNumber.Data;

public class Score
{
    // Function for listing all the Objects in the Score List
    public static void ListHistory()
    {
        // Clear and List all Object-contents per Object
        Console.Clear();
        var i = 1;
        foreach (var _score in Scores)
        {
            Console.WriteLine(
                $"{i} Held by:  {_score.Name} with {_score.NumberOfGuesses} done at {_score.WhenScored} ");
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
        SortScore(Scores);


        var text = File.ReadAllText(filePath);
        if (!string.IsNullOrEmpty(text))
            Scores = JsonSerializer.Deserialize<List<ScoreModel>>(text);
        else
            Scores = new List<ScoreModel>();
    }

    public static void SortScore(List<ScoreModel> scores)
    {
        scores = scores.OrderBy(x => x.NumberOfGuesses).ToList();
        // var listCount = scores.Count();
        // scores = scores.RemoveRange(0,1);
    }

    private static void WriteToScoreFile(List<ScoreModel> scores)
    {
        var content = JsonSerializer.Serialize(scores);
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }


    #region Fields

    private static List<ScoreModel> Scores = new();

    private static readonly string filePath =
        @"C:\Users\danst\source\repos\GuessTheNumber\GuessTheNumber\HighScore\highscore.json";

    private static Score _score;

    #endregion
}