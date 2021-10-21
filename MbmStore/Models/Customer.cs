using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        private DateTime birthdate;
        private List<string> phoneNumbers = new List<string>();

        public int CustomerId { get; set; }
        public string Firstname { get; set;  }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        // read only property
        public List<string> PhoneNumbers
        {
            get { return phoneNumbers; }
        }

        // property that validates input (the set accessor)
        public DateTime Birthdate
        {
            set
            {
                if ((DateTime.Now.Year - value.Year) > 120 ||
                    (DateTime.Now.Year - value.Year) < 0)
                {
                    throw new Exception("Age is not accepted");
                }
                else {
                    birthdate = value;
                }
            }
            get { return birthdate; }
        }

        // read only property
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = 0;
                age = now.Year - birthdate.Year;
                if (now.Month < birthdate.Month ||
                    (now.Month == birthdate.Month && now.Day < birthdate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public List<Invoice> Invoices { get; set; }
        
        

        // cunstructor
        public Customer(int customerId, string firstname, string lastname, string address, string zip, string city)
        {
            CustomerId = customerId;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Zip = zip;
            City = city;
        }

        // method
        public void AddPhoneNumber(string phone)
        {
            phoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }

    }



}