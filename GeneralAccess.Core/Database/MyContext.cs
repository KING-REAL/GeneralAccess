using GeneralAccess.Core.Database.EntityConfigurations;
using GeneralAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAccess.Core.Database
{
    public class MyContext :DbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AuthIconConfiguration());
        }

        public DbSet<AuthIcon> AuthIcons { get; set; }

    }
}
