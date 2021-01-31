using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace PhilarDataApp.Models
{
    public class ConcertDbContext : DbContext
    {
        public ConcertDbContext(DbContextOptions<ConcertDbContext> options) : base(options) { }

        public DbSet<Concert> Concerts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Concert>().ToTable("Concert");
            modelBuilder.Entity<Concert>().HasData(GetConcert());
        }

        private List<Concert> GetConcert()
        {
            return new List<Concert>
            {
                new Concert {Id=01, Title="Концерт – премьера симфонического оркестра филармонии Якутии",
                DateOfThe = new DateTime(2012, 3, 19), ConcertVenue ="САТ им. П.Ойунского", Soloist="", Conductor="Ф. Мастранджело",
                Performer="Симфонический оркестр", Note="", CountCameras=2, Sound=""},
                
                new Concert {Id=2, Title="Концерт – проект большого симфонического оркестра филармонии Якутии",
                DateOfThe = new DateTime(2012, 5, 10), ConcertVenue ="ДДН им. А. Кулаковского", Soloist="Иван Почекин", Conductor="Ф. Мастранджело",
                Performer="Симфонический оркестр", Note="", CountCameras=2, Sound=""}


            };
        }


    }


}
