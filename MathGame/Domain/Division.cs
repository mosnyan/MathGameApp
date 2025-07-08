namespace MathGame.Domain;

public class Division(int dividend, int divisor) : ArithmeticExpression(dividend, divisor)
{
    public override int Result => LeftOperand / RightOperand;

    public override string ToString()
    {
        return $"{LeftOperand} / {RightOperand}";
    }
}