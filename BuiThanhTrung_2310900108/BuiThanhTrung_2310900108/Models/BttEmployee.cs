using System;
using System.Collections.Generic;

namespace BuiThanhTrung_2310900108.Models;

public partial class BttEmployee
{
    public int BttEmpId { get; set; }

    public string? BttEmpName { get; set; }

    public int? BttEmpLevel { get; set; }

    public DateOnly? BttEmpStartDate { get; set; }

    public bool? BttEmpStatus { get; set; }
}
