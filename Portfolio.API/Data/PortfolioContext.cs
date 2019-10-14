using Microsoft.EntityFrameworkCore;
using Portfolio.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.API.Data
{
    public class PortfolioContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public PortfolioContext(DbContextOptions<PortfolioContext> options)
            : base(options)
        {
        }
    }
}
