﻿using System;
using System.Collections.Generic;

namespace CRUDApp.Entities;

public partial class Order
{
    public int Id { get; set; }

    public int StatusId { get; set; }

    public int PickuppointId { get; set; }

    public DateOnly CreateDate { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public string? Username { get; set; }

    public int GetCode { get; set; }

    public virtual PickupPoint Pickuppoint { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User? UsernameNavigation { get; set; }
}
