using proje.Data.Common;
using System;

namespace project.Data.Entity
{
    public class SalesItem : BaseEntity
    {
        private static int _count = 0;
   
        public static string Product { get; private set; }


        public SalesItem()
        {
            _count++;
            No = _count;
        }

        internal static void Add(SalesItem salesItem)
        {
            throw new NotImplementedException();
        }
    }
}
