using Aula2ExemploCrud.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;



namespace Aula2ExemploCrud.Context
{
    public class ContextData : DbContext
    {
        public ContextData(DbContextOptions<ContextData> options) : base(options)
        {

        }

        public DbSet<Medico> medico {get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
        }
    }
}
