﻿using System;
using System.Collections.Generic;

namespace CRUDApp.Entities;

public partial class Status
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
