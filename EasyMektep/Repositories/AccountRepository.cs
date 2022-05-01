using EasyMektep.Interfaces;
using EasyMektep.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMektep.Repositories
{
    public class AccountRepository : IAccountInterface
    {
        public UserModel Login(string login, string password)
        {
            //необходимо сделать метод для подтверждения валидности
            if (login == "bettycooper@gmail.com" && password == "BettyCooper!!!")
                return new UserModel
                {
                    Id=1,
                    Name = "Betty",
                    Surname = "Cooper",
                    Email = "bettycooper@gmail.com",
                    BirthDay = new DateTime(1996,2,2),
                    PhoneNumber = "+7 777 700 99 99",
                    ImgUrl = "/persons/2.svg",
                    Gender = 1
                };
            else
                return null;
        }
    }
}
