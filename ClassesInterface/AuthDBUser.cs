using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Interface;
using ООО__Товары_для_животных_.Models;

namespace ООО__Товары_для_животных_.ClassesInterface
{
    public class AuthDBUser : IAuthDB
    {
        public User UserLoginPassword(string login, string pass)
        {
          return DB.Instance.Users.Include("UserRoleNavigation").FirstOrDefault(s => s.UserPassword == pass & s.UserLogin == login);//
        }
    }
}
