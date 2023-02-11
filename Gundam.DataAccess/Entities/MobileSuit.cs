using System;
using System.Collections.Generic;

namespace Gundam.DataAccess.Entities;

public partial class MobileSuit
{
    public int GundamId { get; set; }

    public string Model { get; set; } = null!;

    public string Pilot { get; set; } = null!;
}
