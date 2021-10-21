using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    

    public class InvoiceController : Controller
    {
        private List<SelectListItem> customers = new List<SelectListItem>();
        
        // GET
        public ActionResult Index()
        {
            
            ViewBag.Invoice = Repository.Invoices;
            
            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem{ Value = invoice.customer.CustomerId.ToString(), Text= invoice.customer.Firstname + " " + invoice.customer.Lastname,});
            }
            // removes duplicate entries with same ID from a IEnumerable – a customer might 
            //have two or more invoices, but we only want them to appear 1 time in the dropdown
                customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => 
                    z.Text).ToList<SelectListItem>();
 
            ViewBag.CustomerId = customers;

            
            return View();
        }

        [HttpPost]
        public ActionResult Index(int? CustomerId)
        {
            IEnumerable<Invoice> invoices = Repository.Invoices; //getting all invoices

            if (CustomerId != null)
            {
                // select invoices for a customer with linq – just one 
                invoices = Repository.Invoices.Where(r => r.customer.CustomerId == CustomerId);
               
            }
            ViewBag.CustomerId = customers;
            ViewBag.Invoice = invoices;
            
            return View();
        }
    }
}