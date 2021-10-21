using System;
using System.Collections.Generic;
using MbmStore.Models;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> Customers = new List<Customer>();

        static Repository()
        {
            
            // Products
            Movie jungleBook = new Movie("Jungle Book", (decimal) 160.50, "junglebook.jpg", "Jon Favreau");
            Movie gladiator = new Movie("Gladiator", (decimal) 49.95, "gladiator.jpg", "Ridley Scott");
            Movie forrestGump = new Movie("Forrest Gump", (decimal) 154.50, "forrest-gump.jpg", "Robert Zemeckis");
            Products.Add(jungleBook);
            Products.Add(gladiator);
            Products.Add(forrestGump);
            
            Book book1 = new Book( "Kafka on the shore", 150, "Haruki Murakami", 2002, "1-84343-110-6", "kafka_on_the_shore.png");
            Book book2 = new Book("Norwegian wood", 230, "Haruki Murakami", 1987, "9780099448822", "norwegian-wood.jpg");

            Products.Add(book1);
            Products.Add(book2);
            
            MusicCD cd1 = new MusicCD("Gumbo", 300,"Pede b & Tue Track" , 2021 , "Sony Music", "Gumbo.jpg");
            
            Track t1 = new Track("Roux", new TimeSpan(00,01,44));
            Track t2 = new Track("Dum og Dummere", new TimeSpan(00,03,44));
            Track t3 = new Track("Kender en", new TimeSpan(00,03,44));
            Track t4 = new Track("Store Pede", new TimeSpan(00,03,40));
            Track t5 = new Track("CtrlAltDel", new TimeSpan(00,03,34));
            Track t6 = new Track("Ketchuhl", new TimeSpan(00,01,15));
            Track t7 = new Track("Nyreslag", new TimeSpan(00,04,27));
            Track t8 = new Track("Må jeg være fri", new TimeSpan(00,03,18));
            Track t9 = new Track("Min by", new TimeSpan(00,03,42));
            Track t10 = new Track("Gi' mig styrke", new TimeSpan(00,02,13));
            Track t11 = new Track("Ornli'", new TimeSpan(00,04,44));
            
            cd1.AddTrack(t1);
            cd1.AddTrack(t2);
            cd1.AddTrack(t3);
            cd1.AddTrack(t4);
            cd1.AddTrack(t5);
            cd1.AddTrack(t6);
            cd1.AddTrack(t7);
            cd1.AddTrack(t8);
            cd1.AddTrack(t9);
            cd1.AddTrack(t10);
            cd1.AddTrack(t11);

            Products.Add(cd1);
            
            //Customers
            
            Customer c1 = new Customer(1, "Lars", "Larsen", "Larsenvej 10", "123", "LarsBy");
            Customer c2 = new Customer(2, "Lone", "Lonesen", "LoneVej 17", "135", "Lonestrup");

            Customers.Add(c1);
            Customers.Add(c2);
            
            // orderItems

            OrderItem o1 = new OrderItem(book1, 10);
            OrderItem o2 = new OrderItem(jungleBook, 10);
            OrderItem o3 = new OrderItem(cd1, 50);
            OrderItem o4 = new OrderItem(book2, 7);
            
            //invoices

            Invoice i1 = new Invoice(1, new DateTime(2021,10,15), c1);
            i1.AddOrderItem(o1);
            i1.AddOrderItem(o2);
            
            Invoice i2 = new Invoice(2, new DateTime(2021,10,20), c2);
            i2.AddOrderItem(o3);
            i2.AddOrderItem(o4);

            Invoices.Add(i1);
            Invoices.Add(i2);




        }
        
        
        
    }
    
}

