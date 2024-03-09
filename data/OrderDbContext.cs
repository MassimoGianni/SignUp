using Microsoft.EntityFrameworkCore;
using SignUp_main.Models;

public class dbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");

    public DbSet<Purchasing> Utenti { get ; set; }
    public DbSet<Order> Prodotti { get ; set;}

    public DbSet<Prenotazione> Ordinamenti { get ; set; }
    
}