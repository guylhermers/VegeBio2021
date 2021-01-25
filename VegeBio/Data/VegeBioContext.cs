using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VegeBio.Models;

namespace VegeBio.Data
{
    public class VegeBioContext : IdentityDbContext
    {
        public VegeBioContext(DbContextOptions<VegeBioContext> options)
            : base(options)
        {
        }
        public DbSet<Produto> ListaProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Produto");

        }
    }
}
