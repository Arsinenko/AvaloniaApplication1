using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1;

public partial class TeachersDtg : UserControl
{
    public TeachersDtg()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        using (var db = new CollegedbContext())
        {
            var teachers = db.Users.Where(t => t.Idrole == 2).ToList();
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"{teacher.Id} {teacher.Name} {teacher.Idrole}");
            }
            DataGridTeacher.ItemsSource = teachers;
        }
    }
}