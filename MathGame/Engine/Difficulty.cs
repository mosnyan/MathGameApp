namespace MathGame.Engine;

public enum Difficulty
{
    None,
    Easy,
    Medium,
    Hard
}

class DifficultyFactory
{
    public static Difficulty Create(int number)
    {
        var d = (Difficulty)number;
        
        if (!Enum.IsDefined(d))
        {
            throw new ArgumentOutOfRangeException($"The number {number} does not correspond to any difficulty.");
        }

        return d;
    }
}