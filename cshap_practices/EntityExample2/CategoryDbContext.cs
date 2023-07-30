using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample2;

public class CategoryDbContext : DbContext
{
    private readonly string _connectionString;
    public CategoryDbContext()
    {
        _connectionString = "Server=DESKTOP-7KDQ6IB\\SQLEXPRESS;Database=PracticedDB1;User Id=practiced1;Password=9876;TrustServerCertificate=True";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Essential> Essential{ get; set; }
}
