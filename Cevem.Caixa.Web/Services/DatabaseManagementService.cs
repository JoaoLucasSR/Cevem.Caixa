using Cevem.Caixa.Web.Data;

using Microsoft.EntityFrameworkCore;

namespace Cevem.Caixa.Web.Services
{
    public static class DatabaseManagementService
    {
        public static void MigrationInitialisation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<ApplicationDbContext>()!.Database.Migrate();
            }
        }
    }
}
