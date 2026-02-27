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
        public DbSet<Person> Persons { get; set; }
    }
}
