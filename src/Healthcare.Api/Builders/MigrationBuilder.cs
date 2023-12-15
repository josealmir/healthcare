using Healthcare.Data;
using Microsoft.EntityFrameworkCore;

namespace Healthcare.Api.Builders 
{
    public static class MigrationBuilder
    {
        public static void UseApplyMigrations(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var ctx = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            ctx.Database.Migrate();
        }
    }
}
