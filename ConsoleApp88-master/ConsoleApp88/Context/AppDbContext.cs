using ConsoleApp88.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Bookstores;Trusted_Connection=true;TrustServerCertificate=true");
        }
       
        public DbSet<authors> authorss { get; set; }
        public DbSet<Books> Bookss { get; set; }
        public DbSet<Category> Categorys { get; set; }


    }
}