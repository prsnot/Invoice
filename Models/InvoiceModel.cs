namespace Invoice.Models
{
    public class InvoiceModel
    {
        public int ID { get; set; }
        public string? InvoiceId { get; set; }
        public DateTime DateIssued { get; set; }
        public float NetAmount { get; set; }
        public float VatAmount { get; set; }
        public float TotalAmount { get; set; }
        public string? Description { get; set; }
        public string? CompanyId { get; set; }  // Issuer Company
        public string? CounterPartyCompanyId { get; set; }  // Receiver Company
    }
}
