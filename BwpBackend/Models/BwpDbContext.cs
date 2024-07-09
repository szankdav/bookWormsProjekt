using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BwpBackend.Models;

public partial class BwpDbContext : DbContext
{
    public BwpDbContext()
    {
    }

    public BwpDbContext(DbContextOptions<BwpDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

}