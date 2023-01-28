using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using RestApi.Models;

namespace RestApi.Models
{
    public class StreetsContext : DbContext
    {
        public DbSet<StreetsModel> StreetsModel { get; set; }
        public StreetsContext(DbContextOptions<StreetsContext> options) : base(options) { }
    }
}
