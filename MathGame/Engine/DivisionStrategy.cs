namespace MathGame.Engine;

using MathGame.Domain;

public class DivisionStrategy : GameStrategy
{
    internal DivisionStrategy(Difficulty difficulty)
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                LowerRange = 1;
                UpperRange = 13;
                break;
            case Difficulty.Medium:
                LowerRange = -25;
                UpperRange = 26;
                break;
            case Difficulty.Hard:
                LowerRange = -50;
                UpperRange = 51;
                break;
            case Difficulty.None:
                throw new ArgumentOutOfRangeException(nameof(difficulty), "Difficulty cannot be None.");
        }
    }
    
    public override ArithmeticExpression GenerateExpression()
    {
        var divisor = GetRandomOperand();
        while (divisor == 0)
        {
            divisor = GetRandomOperand();
        }
        var dividend = GetRandomOperand() * divisor;
        return new Division(dividend, divisor);
    }
}