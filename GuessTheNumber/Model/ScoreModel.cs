namespace GuessTheNumber.Model;

public class ScoreModel
{
    public ScoreModel(string? name, int numberOfGuesses)
    {
        Name = name;
        NumberOfGuesses = numberOfGuesses;
        WhenScored = DateTime.Now;
    }

    public string? Name { get; set; }
    public int NumberOfGuesses { get; set; }
    public DateTime WhenScored { get; set; }
}