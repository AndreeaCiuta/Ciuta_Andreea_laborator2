using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciuta_Andreea_laborator2.Models;

namespace Ciuta_Andreea_laborator2.Data
{
    public class Ciuta_Andreea_laborator2Context : DbContext
    {
        public Ciuta_Andreea_laborator2Context (DbContextOptions<Ciuta_Andreea_laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Ciuta_Andreea_laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ciuta_Andreea_laborator2.Models.Publisher> Publisher { get; set; }

        public DbSet<Ciuta_Andreea_laborator2.Models.Author> Author { get; set; }

        public DbSet<Ciuta_Andreea_laborator2.Models.Category> Category { get; set; }
    }
}
