using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Tamrin.Entities;

namespace Tamrin.DAL
{
    internal class SchoolDBContext : DbContext
    {
        public SchoolDBContext() : base("Data Source=.;Initial Catalog=SchoolDB;Integrated Security=True;Encrypt=False")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(x => x.FirstName)
                .HasMaxLength(30)
                .IsRequired()
                .IsUnicode(true);
            modelBuilder.Entity<Person>()
                .Property(x => x.LastName)
                .HasMaxLength(30)
                .IsUnicode(true);
            modelBuilder.Entity<Person>()
                .Property(x => x.NationalCode)
                .IsUnicode(false)
                .HasMaxLength(10)
                .IsRequired();
            modelBuilder.Entity<Person>()
                .Property(x => x.Role)
                .IsRequired()
                .IsUnicode(true);
            modelBuilder.Entity<Person>()
                .Property(x => x.UserName)
                .IsUnicode(true)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();
            modelBuilder.Entity<Person>()
                .Property(x => x.Password)
                .IsUnicode(true)
                .IsRequired()
                .HasMaxLength(100);    
        }
        public DbSet<Person> People { get; set; }
    }
}
