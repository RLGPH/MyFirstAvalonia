using Avalonia.Controls;
using Avalonia.Interactivity;

namespace FirstAvaloniaProject.Views;

public partial class MainView : UserControl
{
    MathRightOrder mathRightOrder = new();
    NumberSystemConv numberSystemConv = new();
    public MainView()
    {
        InitializeComponent();
    }
    public void BTN_Clear(object source, RoutedEventArgs args)
    {
        TB_First.Clear();
    }
    private void Calculate(object source, RoutedEventArgs args)
    {
        double resault = mathRightOrder.Equation(TB_First.Text);
        TB_Second.Text = resault.ToString();
    }
    private void BTN_mathsymbleplus(object source, RoutedEventArgs args)
    {
        string firstText = TB_First.Text;
        TB_First.Text = firstText + "+";
    }
    private void BTN_mathsymbleminus(object source, RoutedEventArgs args)
    {
        string firstText = TB_First.Text;
        TB_First.Text = firstText + "-";
    }
    private void BTN_mathsymbletimes(object source, RoutedEventArgs args)
    {
        string firstText = TB_First.Text;
        TB_First.Text = firstText + "*";
    }
    private void BTN_mathsymbleDivde(object source, RoutedEventArgs args)
    {
        string firstText = TB_First.Text;
        TB_First.Text = firstText + "/";
    }
    //-------------------number system converter-------------------------//
    private void TB_Decimal_TextChanged(object sender, TextChangedEventArgs e)
    {
        string DecimalST = TB_Decimal.Text;
        int Decimal;
        if (int.TryParse(DecimalST, out Decimal))
        {

            TB_Oktal.Text = numberSystemConv.DecimalToOctal(Decimal);
            TB_Hexa.Text = numberSystemConv.DecimalToHexadecimal(Decimal);
            TB_Binary.Text = numberSystemConv.DecimalToBinary(Decimal);
        }
        else
        {
            TB_Oktal.Text = null;
            TB_Hexa.Text = null;
            TB_Binary.Text = null;
        }
    }

    private void TB_Oktal_TextChanged(object sender, TextChangedEventArgs e)
    {
        string Oktal = TB_Oktal.Text;
        (int? decimalNumber, string? binaryNumber, string? Hexanumber) = numberSystemConv.OctalToDecimal(Oktal);
        TB_Decimal.Text = decimalNumber.ToString();
        TB_Binary.Text = binaryNumber;
        TB_Hexa.Text = Hexanumber;
    }

    private void TB_Binary_TextChanged(object sender, TextChangedEventArgs e)
    {
        string Binary = TB_Binary.Text;
        (int? decimalNumber, string? octalNumber, string? Hexanumber) = numberSystemConv.BinaryToDecimal(Binary);
        TB_Hexa.Text = Hexanumber;
        TB_Oktal.Text = octalNumber;
        TB_Decimal.Text = decimalNumber.ToString();
    }

    private void TB_Hexa_TextChanged(object sender, TextChangedEventArgs e)
    {
        string hexaST = TB_Hexa.Text;
        (int? decimalNumber, string? binaryNumber, string? octalNumber) = numberSystemConv.HexadecimalToDecimal(hexaST);
        TB_Decimal.Text = decimalNumber.ToString();
        TB_Binary.Text = binaryNumber;
        TB_Oktal.Text = octalNumber;
    }
}