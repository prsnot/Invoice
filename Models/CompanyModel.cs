using Microsoft.Extensions.Hosting;

namespace Invoice.Models
{
    public class CompanyModel
    {
            public string? Id { get; set; }  
            public string? Name { get; set; }
            public string? UsersId { get; set; }
            public ICollection<UsersModel> Users { get; }

            public string InvoiceId { get; set; }
            public InvoiceModel Invoice { get; set; }   
    }
}
