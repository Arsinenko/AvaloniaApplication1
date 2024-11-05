using System;
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
        }
       
    }
}