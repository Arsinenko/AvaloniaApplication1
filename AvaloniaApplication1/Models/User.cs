using System;
using System.Collections.Generic;

namespace AvaloniaApplication1.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? Idrole { get; set; }

    public virtual Role? IdroleNavigation { get; set; }

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
