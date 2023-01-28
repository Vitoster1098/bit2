using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using RestApi.Models;

namespace RestApi.Models
{
    public class HousesContext : DbContext
    {
        public DbSet<HousesModel> HousesModel { get; set; }
        public HousesContext(DbContextOptions<HousesContext> options) : base(options) { }
    }
}
