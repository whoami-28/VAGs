using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using VAGFabric;

public class ApplicationDbContext : DbContext
{
    public DbSet<Volkswagen> Volkswagen { get; set; }
    public DbSet<AUDI> AUDI { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyProjectDB;Integrated Security=True;Encrypt=False";
        optionsBuilder.UseSqlServer(connectionString);
    }
}