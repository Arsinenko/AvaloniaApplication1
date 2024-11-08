﻿using System;
using System.Collections.Generic;

namespace AvaloniaApplication1.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Namerole { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
