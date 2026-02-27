using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamrin.Entities;
using Tamrin.DAL;
namespace Tamrin.service
{
    public class PersonService
    {
         PersonRepo repo;
        public PersonService()
        {
            repo = new PersonRepo();
        }
        public OperationResult Add(Person person)
        {

            var result = Validation(person);
            if (result.IsSuccess)
            {
                repo.Add(person);
            }
            return result;
        }
        OperationResult Validation(Person person) 
        {
            if (repo.IsDublicateNationalCode(person.NationalCode))
            {
                return OperationResult.Failed("کد ملی تکراری است");
            }
            else if (repo.IsDublicateUserName(person.UserName))
            {
                return OperationResult.Failed("نام کاربری قبلا انتخاب شده است");
            }
            return OperationResult.Success();
        }



    }
}
