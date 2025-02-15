using apps_api.Apps.Models;
using Microsoft.EntityFrameworkCore;

namespace apps_api.Data.Migrations
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<App> Apps { get; set; }
    }
}
