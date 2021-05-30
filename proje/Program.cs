using project.Servis;
using System;
using System.Text;

namespace proje
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int selection = 0;
            int selection1 = 0;
            int selection2 = 0;
            do
            {
                Console.WriteLine("############");
                Console.WriteLine(" Secin");
                Console.WriteLine("1.Mehsullar uzerinde emeliyyat aparmaq ");
                Console.WriteLine("2.Satislar uzerinde emeliyyat aparmaq");
                Console.WriteLine("3.Sistemden cixmaq ");
                Console.WriteLine("Sechimi daxil et");

                
                string selectionstr = Console.ReadLine();
                selection = int.Parse(selectionstr);
                //do
                //{

                //} while (true);
                switch (selection)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("1.Yeni mehsul elave et");
                            Console.WriteLine("2.Mehsul uzerinde duzelis et ");
                            Console.WriteLine("3.Mehsulu sil ");
                            Console.WriteLine("4.Butun mehsullari goster");
                            Console.WriteLine("5.Categoriyasina gore mehsullari goster ");
                            Console.WriteLine("6.Qiymet araligina gore mehsullari goster ");
                            Console.WriteLine("7.Mehsullar arasinda ada gore axtaris et  ");
                            Console.WriteLine("Sechimi daxil et");

                            
                            string selectionstr1 = Console.ReadLine();
                            while(!int.TryParse(selectionstr1, out selection1))
                            {
                                Console.WriteLine("Nomre daxil et");
                                selectionstr1 = Console.ReadLine();
                            }
                            switch (selection1)
                            {
                                case 1:
                                    Menuservices.AddProduct("string name, double price");
                                    break;
                                case 2:
                                    Menuservices.FixProduct("2.Mehsul uzerinde duzelis et ");
                                    break;
                                case 3:
                                    Menuservices.DeleteItem("3.Mehsulu sil ");
                                    break;
                                case 4:
                                    Menuservices.ShowAllProduct("4.Butun mehsullari goster");
                                    break;

                                case 5:
                                    Menuservices.Catogory("5.Categoriyasina gore mehsullari goster ");
                                    break;

                                case 6:
                                   Menuservices.SwohByPrice("6.Qiymet araligina gore mehsullari goster ");
                                    break;
                                case 7:
                                    Menuservices.SearchBYName("7.Mehsullar arasinda ada gore axtaris et  ");
                                    break;
                                case 0:
                                    Console.WriteLine("Tesekkurler");
                                    break;

                            }
                        } while (!(selection1>=0&&selection1<=7)); 

                        break;

                    case 2:
                        
                        do
                        {
                            Console.WriteLine("1.Yeni satis elave etmek");
                            Console.WriteLine("2.Satisdaki hansisa mehsulun geri qaytarilmasi");
                            Console.WriteLine("3.Satisin silinmesi  ");
                            Console.WriteLine("4.Butun satislarin ekrana cixarilmasi  ");
                            Console.WriteLine("5.Verilen tarix araligina gore satislarin gosterilmesi ");
                            Console.WriteLine("6.Verilen mebleg araligina gore satislarin gosterilmesi ");
                            Console.WriteLine("7.Verilmis bir tarixde olan satislarin gosterilmesi  ");
                            Console.WriteLine("8.Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi");
                            Console.WriteLine("Sechimi daxil et");
                            string selectionstr2 = Console.ReadLine();
                            while (!int.TryParse(selectionstr2, out selection2))
                            {
                                Console.WriteLine("Nomre daxil et");
                                selectionstr2 = Console.ReadLine();
                            }
                            switch (selection2)
                            {

                                case 1:
                                    Menuservices.AddProduct("1.Yeni mehsul elave et");
                                    break;
                                case 2:
                                    Menuservices.FixProduct("2.Mehsul uzerinde duzelis et");
                                    break;
                                case 3:
                                    Menuservices.DeleteItem(" 3.Mehsulu sil");
                                    break;

                                case 4:
                                    Menuservices.ShowAllProduct("4.Butun mehsullari goster");
                                    break;
                                case 5:
                                    Menuservices.Catogory("5.Categoriyasina gore mehsullari goster ");
                                    break;

                                case 6:
                                    Menuservices.SwohByPrice("Qiymet araligina gore mehsullari goster");
                                    break;
                                case 7:
                                    Menuservices.Datetime("7.Verilmis bir tarixde olan satislarin gosterilmesi " );
                                    break;
                                case 8:
                                    Menuservices.Number("8.Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi");
                                    break;
                                case 0:
                                    Console.WriteLine("Tesekkurler");
                                    break;

                            } 
                        
                        } while ((selection2 >=0||selection2<=8));
                        break;
                    case 3 :
                        Menuservices.Exit("Sistemden cixmaq ");
                        Console.WriteLine("Tesekkurler");
                        break;
                }

            }
            while (!(selection>=1&&selection<=3));

        }
    }
}

         
