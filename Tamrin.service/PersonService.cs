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
        public OperationResult Add(PersonDTO personDTO)
        {

            var result = Validation(personDTO);
            if (result.IsSuccess)
            {
                repo.Add(new Person
                { 
                FirstName = personDTO.FirstName,
                LastName = personDTO.LastName,
                NationalCode = personDTO.NationalCode,
                Role = personDTO.Role,
                UserName = personDTO.UserName,
                Password = personDTO.Password, 
                });
            }
            return result;
        }
        public OperationResult Login(string userName,string password)
        {
            var person = repo.Login(userName,password);
            if (person != null)
                return OperationResult.Success();
            return OperationResult.Failed("نام کاربری/رمز عبور اشتباه است") ;
        }
        OperationResult Validation(PersonDTO personDTO) 
        {
            if (repo.IsDublicateNationalCode(personDTO.NationalCode))
            {
                return OperationResult.Failed("کد ملی تکراری است");
            }
            else if (repo.IsDublicateUserName(personDTO.UserName))
            {
                return OperationResult.Failed("نام کاربری قبلا انتخاب شده است");
            }
            else if (personDTO.FirstName==null)
            {
                return OperationResult.Failed("لطفا یک نام انتخاب کنید");
            }
            else if (personDTO.NationalCode.Length!=10)
            {
                return OperationResult.Failed("لطفا کد ملی را درست وارد کنید");
            }
            return OperationResult.Success();
        }



    }
}
