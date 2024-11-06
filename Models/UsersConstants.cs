using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Models
{
    public class UserConstants
    {
        public static List<UsersModel> Company = new List<UsersModel>()
        {
            new UsersModel() { Id = "123", Name = "usre", Password = "P@ssw0rd"},
            new UsersModel() { Id = "1234", Name = "company2", Password = "P@ssw0rd"},
        };
    }
}
