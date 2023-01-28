using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using RestApi.Models;

namespace RestApi.Models
{
    public class ApartmentsContext : DbContext
    {
        public DbSet<ApartmentsModel> ApartmentsModel { get; set; }
        public ApartmentsContext(DbContextOptions<ApartmentsContext> options) : base(options) { }
    }
}
