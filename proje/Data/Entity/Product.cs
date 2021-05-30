using proje.Data.Common;
using System;
using System.Collections.Generic;

namespace project.Data.Entity
{
    public class Product : BaseEntity
    {

        private static int _count = 0;
        internal double price;

        public double Price { get; set; }

        public int Code { get; private set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public int Quantity { get; internal set; }

        public Product()
        {
            _count++;
            No = _count++;
        }
     
        internal void Add(Product product)
        {
            throw new NotImplementedException();
        }

        internal static Product FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }

}

