﻿
namespace FinalProject.DAL.Contexts;
public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Product> Products { get; set; }
}
