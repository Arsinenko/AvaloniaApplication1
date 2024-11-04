using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaApplication1.Models;
using MsBox.Avalonia;

namespace AvaloniaApplication1;

public partial class Login : UserControl
{
    public Login()
    {
        InitializeComponent();
    }

    private void LoginBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        string login = LoginTextBox.Text;
        string password = PasswordTextBox.Text;
        using (var db = new CollegedbContext()) 
        {
            User result = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            
            if (result == null)
            {
                MessageBoxManager.GetMessageBoxStandard(title: "Error", text: "Login or password is incorrect. User not found!").ShowAsync();
            }
            else
            {
                MessageBoxManager.GetMessageBoxStandard(title: "Success", text: "You are logged in!").ShowAsync();
                //change page to AdminPage 
                var mainWindow = this.VisualRoot as MainWindow;
                mainWindow?.NavigeteTo(new AdminPage());
            }
        }
    }
}