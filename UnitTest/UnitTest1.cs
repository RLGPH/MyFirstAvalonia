using FirstAvaloniaProject;

namespace UnitTest;

public class UnitTest1
{
    MathRightOrder mathRightOrder;
    NumberSystemConv numberSystemConv = new();
    [Fact]
    public void simpleMath()
    {
        int answer = mathRightOrder.Equation("2 + 2");
        Equals(answer, 4);
    }

    [Fact]
    public void binærDecimalHexaOctal() 
    {
        (int? decimalNumber, string? octalNumber, string? Hexanumber) = numberSystemConv.BinaryToDecimal("11");
        
        Equals(decimalNumber.ToString(),"3");
        Equals(Hexanumber,"3");
        Equals(octalNumber,"3");
        string binær = numberSystemConv.DecimalToBinary(3);
        Equals(binær, "11");
    }
}