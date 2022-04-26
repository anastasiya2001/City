using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.EF
{
    internal class Models : DbContext
    {
        public DbSet<street_new> streets_new { get; set; }
        public DbSet<home_new> homes_new { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MSI;Database=City;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public void CreateDbIfNotExists()
        {
            this.Database.EnsureCreated();
        }

        public void DropDB()
        {
            this.Database.EnsureDeleted();
        }


        public class street_new
        {
            public int ID { get; set; }
            [MaxLength(50)]
            public string name { get; set; }
        }
        public class home_new
        {
            public int ID { get; set; }
            [MaxLength(50)]
            public string number { get; set; }
            public street_new id_street { get; set; }
            public int amount { get; set; }
            public int year_repair { get; set; }
        }

        public void AddStreets()
        {
            streets_new.AddRange(entities: new street_new[]
               {
                new street_new { name = "Вавилова" },
                new street_new { name = "Вольская" },
                new street_new { name = "Рабочая" },
                new street_new { name = "Чапаева" }
                });
        }

        public void AddHomes()
        {
            homes_new.AddRange(entities: new home_new[]
               {
                new home_new{number = "3-а", id_street = streets_new.First(t => t.ID == 1), amount = 49, year_repair = 2008},
                new home_new{number = "12", id_street = streets_new.First(t => t.ID == 1), amount = 89, year_repair = 2018},
                new home_new{number = "15", id_street = streets_new.First(t => t.ID == 1), amount = 105, year_repair = 2017},
                new home_new{number = "5", id_street = streets_new.First(t => t.ID == 1), amount = 69, year_repair = 2011},
                new home_new{number = "14-б", id_street = streets_new.First(t => t.ID == 1), amount = 49, year_repair = 2008},
                new home_new{number = "23", id_street = streets_new.First(t => t.ID == 2), amount = 228, year_repair = 2018},
                new home_new{number = "3-а", id_street = streets_new.First(t => t.ID == 2), amount = 250, year_repair = 2019},
                new home_new{number = "3-б", id_street = streets_new.First(t => t.ID == 2), amount = 368, year_repair = 2019},
                new home_new{ID = 9, number = "15", id_street = streets_new.First(t => t.ID == 2), amount = 102, year_repair = 2015},
                new home_new{ID = 10, number = "13", id_street = streets_new.First(t => t.ID == 2), amount = 4, year_repair = 2007},
                new home_new{ID = 11, number = "55", id_street = streets_new.First(t => t.ID == 3), amount = 498, year_repair = 2021},
                new home_new{ID = 12, number = "7", id_street = streets_new.First(t => t.ID == 3), amount = 16, year_repair = 2010},
                new home_new{ID = 13, number = "11", id_street = streets_new.First(t => t.ID == 3), amount = 189, year_repair = 2014},
                new home_new{ID = 14, number = "25", id_street = streets_new.First(t => t.ID == 3), amount = 77, year_repair = 2012},
                new home_new{ID = 15, number = "13-а", id_street = streets_new.First(t => t.ID == 4), amount = 49, year_repair = 2009},
                new home_new{ID = 16, number = "13-б", id_street = streets_new.First(t => t.ID == 4), amount = 68, year_repair = 2016},
                new home_new{ID = 17, number = "3-а", id_street = streets_new.First(t => t.ID == 4), amount = 102, year_repair = 2022},
                new home_new{ID = 1, number = "17", id_street = streets_new.First(t => t.ID == 4), amount = 210, year_repair = 2020}
                });
        }
    }

}
