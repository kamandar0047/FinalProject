using project.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace proje
{
 interface IMarketable
    {

        //Satis elave etmek
        public void AddSales(int productNo, string name, string category, double price) { }
        //Satis qaytarmaq 
        public void ReturnSales(string Name, int count) { }
        //Her seyi qaytarmaq
        public void ReturnAll(int count) { }
        //Vaxt araligina gore axtaris etmek
        public void SearchByDate(DateTime startdate, DateTime enddate) { }
        //Vaxta gore axtaris etmek
        public void Datetime(DateTime time) { }
        //Reqeme gore axtaris etmek
        public void Number(int no) { }
        //Qiymet araligina gore axtaris etmek
        public void SearchBypPrice(double startprice, double endprice) { }
        //Mehsul elave etmek
        public void AddProduct(string Name, double price) { }
        //Mehsulu deyismek
        public void FixProduct(int no,string Name) { }
        //Mehsulu qaytarmaq
        public void ReturnProduct(int number,string name,int quantity) { }
        //Butun mehsullari gostermek
        public void ShowAllProduct(string Name) { }
        //SatisItemi elave etmek
        public void AddSalesItem(int count, string Name) { }
        //Sales item silmek
        public void DeleteSalesItem(int No);
   //Satis elave etmek
        public void AddSales(int code, int quantity) { }
        //Rapor Menusu
        public void ReportMenu(string Name) { }
        //Katagoriyay gore
        public static void Catogory(int no, string Name) { }

       
    }
}
