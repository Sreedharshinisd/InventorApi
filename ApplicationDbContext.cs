using Microsoft.EntityFrameworkCore;
using InventoryApi.Models;

namespace InventoryApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<InventoryItem> InventoryItems { get; set; } = null!;
    }
}