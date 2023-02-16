namespace GuessTheNumber.Model;

public class ScoreModel
{
    public string Name { get; set; }
    public int NumberOfGuesses { get; set; }
    public DateTime WhenScored { get; set; }
}