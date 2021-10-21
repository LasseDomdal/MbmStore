using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal totalPrice;


        public int InvoiceId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice
        {
            get;

        }

        public Customer customer;

        private List<OrderItem> orderItemsList = new List<OrderItem>();

        public List<OrderItem> OrderItemsList
        {
            get { return orderItemsList; }
        }
        

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.customer = customer;
            InvoiceId = invoiceId;
            OrderDate = orderDate;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItemsList.Add(orderItem);
           
        }

        

      
    }
}