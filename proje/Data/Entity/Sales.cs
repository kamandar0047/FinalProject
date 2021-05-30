using proje.Data.Common;
using System;
using System.Collections.Generic;

namespace project.Data.Entity
{
    public class Sales : BaseEntity

    {
        private static int _count = 0;
        internal List<Product> product;
        internal List<Sales> sales;
        public int value { get; set; }
        public int SalesItem { get; set; }
       public int Quantity { get; set; }
        public string Result { get; internal set; }
        public DateTime Date { get; set; }
        public Product Product { get; internal set; }
        public int No { get; set; }
        public string Name { get; set; }
        public double Cost { get; internal set; }

        public Sales()
        {
            _count++;

            No = _count;
            Date = DateTime.Now;
        }

       public void Add(Sales sales)
        {
            throw new NotImplementedException();
        }

        internal static object FindAll(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }

}

