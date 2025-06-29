using Microsoft.EntityFrameworkCore;
using FinanceHub.API.Models;

namespace FinanceHub.API.Data
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : base(options) { }
        public DbSet<Investment> Investments { get; set; }
    }
} 