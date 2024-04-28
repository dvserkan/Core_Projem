using Core_Projem_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Projem_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PVJ83UH\\POSSQL;initial Catalog=MyCoreProjeApi;integrated Security=true;TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }

    }
}
