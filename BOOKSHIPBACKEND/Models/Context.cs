using Microsoft.EntityFrameworkCore;
using System;
namespace BOOKSHIPBACKEND.Models;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=localhost; database=bookship; Trusted_Connection=true;TrustServerCertificate=True");
    }
    public DbSet<UserInfoClass> UserInfoClasses { get; set; }
}

