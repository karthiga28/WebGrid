using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCGrid.Models
{
    public class MaterialViewModel
    {
        public string Name { get; set; }

        public string ShortCode { get; set; }

        public string Price { get; set; }
    }
    public class Test
    {
        public string comments { get; set; }
        public string id { get; set; }
    }
    public class Invoice
    {
        public string Id { get; set; }
        public string InvoiceNumber { get; set; }
        //public List<LineItem> LineItems { get; set; }
        //public DateTime DateCreated { get; set; }
        //public decimal Total { get; set; }


        //public Invoice()
        //{
        //    LineItems = new List<LineItem>();
        //}

        public class LineItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Total { get; set; }

        }
    }
}
