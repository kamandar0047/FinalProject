using project.Data.Entity;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proje.Data.Enums;
using proje.Data.Common;



namespace proje.Services
{
    public class MarketServices : IMarketable
    {
        public string result;
        public object productName;

        private int no;
        internal static IEnumerable<object> sales;

        public List<Sales> Sales { get; set; }
        public List<Product> Product { get; set; }
        public List<SalesItem> SalesItem { get; set; }
        public double Cost { get; private set; }

        public MarketServices()
        {
            Sales sales = new Sales();
            Product product = new Product();
            SalesItem salesItems = new SalesItem();

        }
        #region Product

        //Satis elave etmek
        public void AddSales(int productNo, string name, string category, double price)
        {
            if (no <= 0)
                throw new ArgumentOutOfRangeException("Product code");
            
            Sales sales = new Sales();
            Product product =Product.FirstOrDefault(s => s.Price== price);
            if (product == null)
                throw new KeyNotFoundException();

        }


        //Mehsul elave etmek
        public void AddProduct(string Name, double price)
        {
            Product product = new Product();
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentNullException("Name");

            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }
            Product Product = new Product();
            Product.Name = Name;

            Product.price = price;

            Product.Add(Product);


        }

        internal static void AddProduct(double v)
        {
            throw new NotImplementedException();
        }

        //Verilen vaxta gore axtaris etmek
        public void SearchByDate(DateTime startdate, DateTime enddate)
        {
            var result = Product.Where(m => m.date >= startdate && m.date <= enddate);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }

        //Qiymete gore axtaris etmek

        #endregion
        public List<Product> SearchBypPrice(double startprice, double endprice)
        {


            double s = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());

            if (startprice <= 0)
                throw new ArgumentOutOfRangeException("Product startprice");
            if (endprice <= 0)
                throw new ArgumentOutOfRangeException("Product endprice");
            var amd = Product.FindAll(s => s.Price >= startprice && s.Price <= endprice);
            if (amd == null)
                throw new KeyNotFoundException();
            return amd.ToList();

        }

        //Katagoriyasina gore
        public enum Catagory
        {

        }

        #region
        //Mehsul qurasdirmaq
        public void FixProduct(int no, string Name)
        {
            int count = Product.Count;
            if (count <= 0)
                throw new KeyNotFoundException();
        }

        #endregion
        #region
        //Mehsulu qaytarmaq
        public void ReturnProduct(int number, string name, int quantity)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException("Insert number");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentOutOfRangeException("name");
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException("quantity");
            Product product = Product.FirstOrDefault(s => s.Name == name);
            if (product == null)
                throw new KeyNotFoundException();
            Sales sales = Sales.FirstOrDefault(s => s.Name == name);
            if (sales == null)
                throw new KeyNotFoundException();




            #endregion
        }
        //Butun mehsullari qaytarmaq
        public void ReturnAllProduct()
        {

        }
        #region  ShowAllProduct
        //Butun mehsullari goster
        public void ShowAllProduct(string Name)
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentNullException("Name");
        }


        #endregion

        //satis elave etmek
        #region
        public void AddSales(int code, int quantity) {
        

            if (code <= 0)
            
                throw new ArgumentOutOfRangeException("Product code");


            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(" Product quantity");
            int option = 0;
            Sales sales = new Sales();
            Product product = Product.FirstOrDefault(s => s.Code == code);
            if (product == null)
                throw new KeyNotFoundException();
            Product acb = new Product();

            acb.Quantity = quantity;

            product.Quantity = product.Quantity - quantity;
           sales.Cost += product.Price * quantity;




        }
        //Satisitemi elave etmek
        public void AddSalesItem(int count, string Name)
        {
            if (count <= 0)
            {
                throw new ArgumentNullException("count");
            }


            SalesItem salesItem = new SalesItem();

            salesItem.No = count;

            SalesItem.Add(salesItem);


        }
        //Satis itemi silmek
        public void DeleteSalesItem(int No)
        {
            int count = SalesItem.Count;

            if (count == -1)
            {
                throw new KeyNotFoundException();
            }
            else
            {
                SalesItem.RemoveAt(No);
            }
        }
        #region Sales
        //Satisi qaytarmaq

        public void ReturnSales(string Name, int count)
        {
            if (count < 0)
            
                throw new KeyNotFoundException("count");
               Sales sales = Sales.FirstOrDefault(s => s.Cost ==Cost);
                if (sales == null)
                    throw new KeyNotFoundException();

                throw new NotImplementedException("Name");
        }
        //Vaxta araligina gore elave etmek
        public void Datetime(DateTime time) { 
        
            var sales = Sales.Where(m => m.Date == time).ToList();
           
        }

        //Qiymete araligina  gore tapmaq
        public List<Sales>SwohByPrice(double startprice, double endprice) { 


        double s = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            if (startprice <= 0)
                throw new ArgumentOutOfRangeException("startprice");
            if (endprice <= 0)
                throw new ArgumentOutOfRangeException("endprice");
            var index = Sales.FindAll(s => s.value >= startprice && s.value <= endprice);
            if (index == null)
                throw new KeyNotFoundException();
            return index.ToList();
        }
    }
}
        #endregion
        
    #endregion


