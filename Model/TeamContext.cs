using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEntityFrameworkCore.Model
{
    class TeamContext : DbContext
    {
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TeamDB;Trusted_Connection=True;");
        }

    }
}
