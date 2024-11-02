using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1.Models;
using MsBox.Avalonia;
using Tmds.DBus.Protocol;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        // ListOfRoles();
        InitializeComponent();
        NavigeteTo(new AdminPage());
    }

    public void NavigeteTo(UserControl page)
    {
        MainContent.Content = page;
    }
}