using System;
using Microsoft.EntityFrameworkCore;

namespace WaterProject.Models
{
    public class CharityDbContext : DbContext
    {
        // This is the constructor

        public CharityDbContext (DbContextOptions<CharityDbContext> options) : base (options) 
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
