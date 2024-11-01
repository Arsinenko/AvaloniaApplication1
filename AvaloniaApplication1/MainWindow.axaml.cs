using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RegistrationBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        string login = LoginBox.Text;
        string password = PasswordBox.Text;
        try
        {
            using (var db = CollegedbContext())
            {
                db.
            }
        }
    }
}