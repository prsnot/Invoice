namespace Invoice.Models
{
    public class CompanyModel
    {
            public int ID { get; set; }
            public string? Id { get; set; }  
            public string? Name { get; set; }
            public string? Password { get; set; }
            public List<string>? Users { get; set; }
        
    }
}
