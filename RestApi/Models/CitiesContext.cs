using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Models
{
    public class CitiesContext : DbContext
    {
        public DbSet<CitiesModel> CitiesModel { get; set; }
        public DbSet<StreetsModel> StreetsModel { get; set; }
        public CitiesContext(DbContextOptions<CitiesContext> options) : base(options) { }
    }
}
