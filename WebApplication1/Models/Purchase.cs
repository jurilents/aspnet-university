using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }


        public int BookId { get; set; }
        public Book Book { get; set; }


        // one-to-many foreign key
        public int CustomerId { get; set; }

        // one-to-many navigation property
        public Customer Customer { get; set; }
    }
}
