using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using RestApi.Models;

namespace RestApi.Models
{
    public class CitiesContext : DbContext
    {
        public DbSet<CitiesModel> CitiesModel { get; set; }
        public CitiesContext(DbContextOptions<CitiesContext> options) : base(options) { }        
    }
}
