namespace MathGame.Domain;

public class Subtraction(int minuend, int subtrahend) : ArithmeticExpression(minuend, subtrahend)
{
    public override int Result => LeftOperand - RightOperand;

    public override string ToString()
    {
        return $"{LeftOperand} - {RightOperand}";
    }
}