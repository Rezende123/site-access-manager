using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace SiteAccessManager.Models
{
    public class SiteContext : DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options)
            : base(options)
        {
        }

        public DbSet<Site> Sites { get; set; } = null!;
    }
}