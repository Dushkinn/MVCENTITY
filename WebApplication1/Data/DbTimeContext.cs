using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DbTimeContext : DbContext
    {
        public DbTimeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Friends> Friends { get; set; }
        public DbSet<TimeCapsule> TimeCapsule { get; set; }
        public DbSet<TimeCapsuleFiles> TimeCapsuleFiles { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<StringFiles> StringFiles { get; set; }
        public DbSet<ImageFiles> ImageFiles { get; set; }

    }
}
