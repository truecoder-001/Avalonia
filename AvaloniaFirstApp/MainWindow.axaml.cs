using Avalonia.Controls;
using Avalonia.Interactivity;
namespace FirstApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void clickMeHandler(object sender, RoutedEventArgs e)
    {
        message.Text =
          (message.Text == "Button Clicked") ?
           "Box with a drop shadow" : "Button Clicked";
    }


}