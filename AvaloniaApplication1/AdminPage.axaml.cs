using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication1;

public partial class AdminPage : UserControl
{
    public AdminPage()
    {
        InitializeComponent();
        AdminPageContent.Content = new UsersDtg();
    }
}