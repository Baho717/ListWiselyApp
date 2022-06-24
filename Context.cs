using Microsoft.EntityFrameworkCore;
using ListWiselyApp.Models;
using ListWiselyApp.Controllers;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=ListWiselyApp.db");
    }

    public DbSet<Medication>? Medications { get; set; }
}