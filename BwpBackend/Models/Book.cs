using System;
using System.Collections.Generic;

namespace BwpBackend.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;
}
