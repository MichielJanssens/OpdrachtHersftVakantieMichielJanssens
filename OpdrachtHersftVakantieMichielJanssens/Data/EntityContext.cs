using Microsoft.EntityFrameworkCore;
using OpdrachtHersftVakantieMichielJanssens.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtHersftVakantieMichielJanssens.Data
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasKey(b => b.Id);

        }

        public DbSet<Book> Books { get; set; }
    }
}
