using System;
using System.Collections.Generic;

namespace AvaloniaApplication1.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public int? Iduser { get; set; }

    public bool? Curator { get; set; }

    public virtual User? IduserNavigation { get; set; }
}
