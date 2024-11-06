using System.Reflection.Metadata;

namespace Invoice.Models
{
    public class UsersModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }

        public string? CompanyId { get; set; }
        public CompanyModel Company { get; set; }

    }
}
