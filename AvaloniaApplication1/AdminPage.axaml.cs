using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication1;

public partial class AdminPage : UserControl
{
    public AdminPage()
    {
        InitializeComponent();
        AdminPageContent.Content = new UsersDtg();
    }

    private void ShowUsersDtg_OnClick(object? sender, RoutedEventArgs e)
    {
            AdminPageContent.Content = new UsersDtg();
    }

    private void ShowTeachersDtg_OnClick(object? sender, RoutedEventArgs e)
    {
        AdminPageContent.Content = new TeachersDtg();
    }
}