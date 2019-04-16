using MasterChefCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChefCore.Contexts
{
    public class MasterChefContext : DbContext
    {
        public MasterChefContext(DbContextOptions<MasterChefContext> options) : base(options){ }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Receita> Receitas { get; set; }
    }
}
