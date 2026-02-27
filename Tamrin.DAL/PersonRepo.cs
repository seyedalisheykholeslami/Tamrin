using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamrin.Entities;

namespace Tamrin.DAL
{
    public class PersonRepo
    {
        SchoolDBContext DB;
        public PersonRepo()
        {
            DB = new SchoolDBContext();
        }
        public void Add(Person person)
        { 
        DB.People.Add(person);
            DB.SaveChanges();
        }

        public bool IsDublicateNationalCode(string nationalCode )
        {
            return DB.People.Any(x => x.NationalCode == nationalCode);
        }
        public bool IsDublicateUserName(string userName)
        {
            return DB.People.Any(x => x.UserName == userName);
        }
        public Person Login(string userName,string password="")
        { 
            return DB.People 
                .Where(x => x.UserName == userName && x.Password == password)
                .SingleOrDefault();
        }
    }
}
