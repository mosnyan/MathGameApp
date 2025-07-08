namespace MathGame.Domain;

public abstract class ArithmeticExpression(int leftOperand, int rightOperand)
{
    protected int LeftOperand { get; } = leftOperand;
    protected int RightOperand { get; } = rightOperand;
    public abstract int Result { get; }
    public abstract override string ToString();
}