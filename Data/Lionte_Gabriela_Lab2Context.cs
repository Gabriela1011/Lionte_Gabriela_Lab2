using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lionte_Gabriela_Lab2.Models;

namespace Lionte_Gabriela_Lab2.Data
{
    public class Lionte_Gabriela_Lab2Context : DbContext
    {
        public Lionte_Gabriela_Lab2Context (DbContextOptions<Lionte_Gabriela_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Lionte_Gabriela_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Lionte_Gabriela_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Lionte_Gabriela_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Lionte_Gabriela_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
