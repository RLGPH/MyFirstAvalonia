using Avalonia.Controls;
using Avalonia.Interactivity;

namespace FirstAvaloniaProject.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    private void MoveText(object source, RoutedEventArgs args)
    {
        TB_Second.Text = TB_First.Text;
    }
}
