using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pascu_Bianca_Lab8.Models;

namespace Pascu_Bianca_Lab8.Data
{
    public class Pascu_Bianca_Lab8Context : DbContext
    {
        public Pascu_Bianca_Lab8Context (DbContextOptions<Pascu_Bianca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pascu_Bianca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pascu_Bianca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pascu_Bianca_Lab8.Models.Category> Category { get; set; }
    }
}
