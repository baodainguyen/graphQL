using GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }  // As Table of DB
    }
}