namespace MathGame.Domain;

public class Multiplication(int multiplicand, int multiplier) : ArithmeticExpression(multiplicand, multiplier)
{
    public override int Result => LeftOperand * RightOperand;

    public override string ToString()
    {
        return $"{LeftOperand} * {RightOperand}";
    }
}