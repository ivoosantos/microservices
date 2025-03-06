using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GeekShopping.IdentityServer.Model.Context
{
    public class PostgreSQLContext : IdentityDbContext<ApplicationUser>
    {
        public PostgreSQLContext() { }
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
    }
}
