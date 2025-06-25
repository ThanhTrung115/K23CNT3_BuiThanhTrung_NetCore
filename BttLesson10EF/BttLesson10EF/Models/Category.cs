using System;
using System.Collections.Generic;

namespace BttLesson10EF.Models;

public partial class Category
{
    public int CateId { get; set; }

    public string? CateName { get; set; }

    public bool? CateStaus { get; set; }
}
