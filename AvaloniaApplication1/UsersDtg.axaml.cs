using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1;

public partial class UsersDtg : UserControl
{
    public UsersDtg()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        using (var db = new CollegedbContext())
        {
            var users = db.Users.ToList();
            DataGridUsr.ItemsSource = users;
            
            DataGridUsr.Columns.Add(new DataGridTextColumn {Header = "ID", Binding = new Avalonia.Data.Binding("id")});
            DataGridUsr.Columns.Add(new DataGridTextColumn {Header = "Name", Binding = new Avalonia.Data.Binding("name")});
            DataGridUsr.Columns.Add(new DataGridTextColumn {Header = "Login", Binding = new Avalonia.Data.Binding("login")});
            DataGridUsr.Columns.Add(new DataGridTextColumn {Header = "Password", Binding = new Avalonia.Data.Binding("password")});
            DataGridUsr.Columns.Add(new DataGridTextColumn {Header = "IdRole", Binding = new Avalonia.Data.Binding("idrole")});
        }
    }
}