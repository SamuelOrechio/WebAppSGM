using Microsoft.EntityFrameworkCore;
using SGM.AplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGM.Infrastructure
{
   public class Context : DbContext
        {
        public Context(DbContextOptions<Context> options) : base (options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaTipo> PessoaTipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<PessoaTipo>().ToTable("PessoaTipo");
        }
    }
}
