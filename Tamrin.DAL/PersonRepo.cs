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
        DB.Persons.Add(person);
        }

        public bool IsDublicateNationalCode(string nationalCode )
        {
            return DB.Persons.Any(x => x.NationalCode == nationalCode);
        }
        public bool IsDublicateUserName(string userName)
        {
            return DB.Persons.Any(x => x.UserName == userName);
        }
    }
}
