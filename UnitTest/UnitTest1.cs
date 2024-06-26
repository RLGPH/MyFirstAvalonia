using FirstAvaloniaProject;

namespace UnitTest;

public class UnitTest1
{
    MathRightOrder mathRightOrder;
    [Fact]
    public void Test1()
    {
        int answer = mathRightOrder.Equation("2+2");
        Equals(answer,4);
    }
}