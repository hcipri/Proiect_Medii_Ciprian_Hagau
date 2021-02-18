using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect2_Medii_Ciprian_Hagau.Models;

namespace Proiect2_Medii_Ciprian_Hagau.Data
{
    public class Proiect2_Medii_Ciprian_HagauContext : DbContext
    {
        public Proiect2_Medii_Ciprian_HagauContext (DbContextOptions<Proiect2_Medii_Ciprian_HagauContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect2_Medii_Ciprian_Hagau.Models.Book> Book { get; set; }

        public DbSet<Proiect2_Medii_Ciprian_Hagau.Models.Publisher> Publisher { get; set; }

        public DbSet<Proiect2_Medii_Ciprian_Hagau.Models.Category> Category { get; set; }
    }
}
