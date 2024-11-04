using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Models
{
    public class CompanyConstants
    {
        public static List<CompanyModel> Company = new List<CompanyModel>()
        {
            new CompanyModel() { Id = "company1", Name = "company1", Password = "P@ssw0rd"},
            new CompanyModel() { Id = "company2", Name = "company2", Password = "P@ssw0rd"},
        };
    }
}
