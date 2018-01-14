using Microsoft.EntityFrameworkCore;
using SpaASMRBackend.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaASMRBackend.Persistence
{
    public class SpaASMRDbContext : DbContext
    {
        public SpaASMRDbContext(DbContextOptions<SpaASMRDbContext> options)
            : base(options)
        {
        }

        public DbSet<Video> Videos { get; set; }
    }
}
