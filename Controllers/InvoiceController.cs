using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Invoice.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;


namespace Invoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private IConfiguration _config;

        public InvoiceController(IConfiguration config)
        {
            _config = config;
        }


        // POST api/invoice
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Invoice([FromBody] InvoiceModel invoice)
        {
            //var companyId = AuthService.GetCompanyIdFromToken(token.Replace("Bearer ", ""));
            if (invoice.InvoiceId == null)
            {
                return Unauthorized("Invalid or missing token");
            }

            //Database.Invoices.Add(invoice);
            return Ok(invoice);
        }

        //[HttpGet("sent")]
        //public ActionResult<IEnumerable<InvoiceModel>> GetSentInvoices([FromQuery] string? counterPartyCompanyId = null, [FromQuery] DateTime? dateIssued = null, [FromQuery] string? invoiceId = null)
        //{
            
        //    if (companyId == null)
        //    {
        //        return Unauthorized("Invalid or missing token");
        //    }

        //    var sentInvoices = Database.Invoices
        //        .Where(i => i.CompanyId == companyId &&
        //                    (counterPartyCompanyId == null || i.CounterPartyCompanyId == counterPartyCompanyId) &&
        //                    (dateIssued == null || i.DateIssued.Date == dateIssued.Value.Date) &&
        //                    (invoiceId == null || i.InvoiceId == invoiceId))
        //        .ToList();

        //    return Ok(sentInvoices);
        //}

        //// GET api/invoice/received
        //[HttpGet("received")]
        //public ActionResult<IEnumerable<Invoice>> GetReceivedInvoices([FromHeader(Name = "Authorization")] string token,
        //    [FromQuery] string counterPartyCompanyId = null, [FromQuery] DateTime? dateIssued = null, [FromQuery] string invoiceId = null)
        //{
        //    var companyId = AuthService.GetCompanyIdFromToken(token.Replace("Bearer ", ""));
        //    if (companyId == null)
        //    {
        //        return Unauthorized("Invalid or missing token");
        //    }

        //    var receivedInvoices = Database.Invoices
        //        .Where(i => i.CounterPartyCompanyId == companyId &&
        //                    (counterPartyCompanyId == null || i.CompanyId == counterPartyCompanyId) &&
        //                    (dateIssued == null || i.DateIssued.Date == dateIssued.Value.Date) &&
        //                    (invoiceId == null || i.InvoiceId == invoiceId))
        //        .ToList();

        //    return Ok(receivedInvoices);
        //}
    }
}
