using IsBasvurusu.Models.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsBasvurusu.Models.data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
                
        }

        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sehir>().HasData(
                new Sehir { Id = 1, Ad = "Adana" },
                new Sehir { Id = 2, Ad = "Ankara" },
                new Sehir { Id = 3, Ad = "İstanbul" },
                new Sehir { Id = 4, Ad = "İzmir" },
                new Sehir { Id = 5, Ad = "Gaziantep" },
                new Sehir { Id = 6, Ad = "Mersin" },
                new Sehir { Id = 7, Ad = "Muğla" },
                new Sehir { Id = 8, Ad = "Antalya" },
                new Sehir { Id = 9, Ad = "Elazığ" },
                new Sehir { Id = 10, Ad = "Trabzon" },
                new Sehir { Id = 11, Ad = "Rize" },
                new Sehir { Id = 12, Ad = "Eskişehir" },
                new Sehir { Id = 13, Ad = "Afyon" },
                new Sehir { Id = 14, Ad = "Çanakkale" },
                new Sehir { Id = 15, Ad = "Krakow" },
                new Sehir { Id = 16, Ad = "Barcelona" },
                new Sehir { Id = 17, Ad = "Hamburg" },
                new Sehir { Id = 18, Ad = "Budapeşte" },
                new Sehir { Id = 19, Ad = "Kahire" },
                new Sehir { Id = 20, Ad = "Rio" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
