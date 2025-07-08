namespace MathGame.Domain;

public class Addition(int augend, int addend) : ArithmeticExpression(augend, addend)
{
    public override int Result => LeftOperand + RightOperand;

    public override string ToString()
    {
        return $"{LeftOperand} + {RightOperand}";
    }
}