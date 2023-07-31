using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample;

public class CategoryDbContext : DbContext
{
    private readonly string _connectionString;
    public CategoryDbContext()
    {
        _connectionString = "Server=DESKTOP-7KDQ6IB\\SQLEXPRESS;Database=PracticedDB2;User Id=practiced2;Password=9876;TrustServerCertificate=True";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
}
