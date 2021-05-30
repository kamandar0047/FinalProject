using DocumentFormat.OpenXml.Wordprocessing;
using proje;
using proje.Services;
using project.Data.Entity;
using System;

namespace project.Servis
{
    public static class Menuservices
    {
       static MarketServices marketServices = new MarketServices();
        //Satisin ekrana verilmesi
        public static void DisplaySales(int no,string name,double price)
        {
            var table = new ConsoleTable("No", "name", " price");
            

            foreach (var product in marketServices.Sales)
            {
                table.AddRow(product.No, product.SalesItem, product.Result);
            }

            table.Write();
            Console.WriteLine();
        }

        //Mehsulun ekrana verilmesi
        public static void DisplayProduct(int no,string name,int count)  
        {
            ConsoleTable table = new ConsoleTable("No", "name", "count");
            Product product = new Product();

            foreach (var item in marketServices.Product) 
                
            {
                table.AddRow(product.No, product.Name);
            }

            table.Write();
            Console.WriteLine();
        }

        //Mehsulu menu kimi elave etmek

        public static void AddProductMenu(string name,double price)
        {
            Console.WriteLine("Insert Name");
            string fullname = Console.ReadLine();

         

            Console.WriteLine("Insert Session Price");
            string priceStr = Console.ReadLine();

            try
            {
                MarketServices.AddProduct(double.Parse(priceStr));
                Console.WriteLine("Product instered");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please try again");
                Console.WriteLine(e.Message);
            }
        }
        //Katagoriyaya gore elave etmek
        public static void Catogory(string name) => throw new NotImplementedException();
        //Qiymeti araligina gore goster
        public static void SwohByPrice(double startprice,double endprice)
        {
            double s = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
        }
        //Butun productlari goster
        public static void ShowAllProduct(string name)
        {
            throw new NotImplementedException("name");
        }
        //Productlari qurasdir
        public static void FixProduct(string name)
        {
            throw new NotImplementedException("name");
        }
        //Produc elave etmek       `
        public static void AddProduct(string name)
        {
            throw new NotImplementedException();
        }

        //Satis itemi elave etmek menusu
        public static void AddSalesItemMenu(string name)
        {
            throw new NotImplementedException();
        } 
          // Ada gore axtaris etmek
        public static void SearchBYName(string name)
        {
            throw new NotImplementedException();
        }

        //Mehsulu ekrana vermek
        public static void DisplaProduct(int no,string name,int count)

        {
            ConsoleTable table = new ConsoleTable("No", "name", "count");
            Product product = new Product();

            foreach (var products in MarketServices.sales)
            {

                table.AddRow(product.No, product.Name);
            }
            table.Write();
            Console.WriteLine();

        }
        //Satis menusu elave etmek
        public static void AddSalesMenu()//
        {
            throw new NotImplementedException();
        }


        //Itemi silmek
        public static void DeleteItem(string name)
        {
            throw new NotImplementedException("name");
        }
        //Satis elave etmek
        public static void AddSales(string name)
        {
            throw new NotImplementedException("name");
        }
        //Mehsulu geri qaytarmaq
        public static void ReturnProduct(string name)
        {
            throw new NotImplementedException("name");
        }
        //Satisi geri qaytartmaq
        public static void ReturnSales(string name)
        {
            throw new NotImplementedException("name");
        }
        //Satisi silmek
        public static void DeleteSales(string name)
        {
            throw new NotImplementedException("name");
        }
        //Verilen vaxta gore tapmaq    
        public static void Datetime(string name)
        {
            throw new NotImplementedException("name");
        }    
         //Qiymete gore axtarmaq
        public static void SwohByPrice(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name");
        }
         


        //Verilen noreye gore axtaris
       public static void Number(string name)
        {
            throw new NotImplementedException();
        }
         //Ada gore axtarmaq
       public static void SearchByName(string name)
        { }
        //Cixis vermek
        public static void Exit(string name)
        {
            throw new NotImplementedException();
        }
    }

}