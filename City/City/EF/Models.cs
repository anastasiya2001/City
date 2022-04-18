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
        public DbSet<street> streets { get; set; }
        public DbSet<home> homes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MSI;Database=City2;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public void CreateDbIfNotExists()
        {
            this.Database.EnsureCreated();
        }
    }

    public class street
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string name { get; set; }
    }
    public class home
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string number { get; set; }
        public street id_street { get; set; }
        public int amount { get; set; }
        public int year_repair { get; set; }
    }

}
