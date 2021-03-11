using DbConnectivity.Models;
using Microsoft.EntityFrameworkCore;

namespace DbConnectivity.Db
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        { }
        public DbSet<UserTest> UserTests { get; set; }
    }
}