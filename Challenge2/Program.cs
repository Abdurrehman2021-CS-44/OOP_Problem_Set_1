using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2.BL;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<productData> productInfo = new List<productData>();
            string option;
            option = " ";
            while (true)
            {
                Console.Clear();
                option = mainMenu();
                if(option == "1")
                {
                    productInfo.Add(addProduct());
                }
                else if (option == "2")
                {
                    viewProduct(productInfo);
                }
                else if (option == "3")
                {
                    highestPricedProduct(productInfo);
                }
                else if (option == "4")
                {
                    addTax(productInfo);
                }
                else if (option == "5")
                {

                }
                else if (option == "6")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
        static string mainMenu()
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Product");
            Console.WriteLine("3. Find the Product with the Highest Price Unit");
            Console.WriteLine("4. View sales Tax of All Product");
            Console.WriteLine("5. Product to be Ordered");
            Console.WriteLine("6. Exit");
            string option;
            Console.Write("Your Option...");
            option = Console.ReadLine();
            return option;
        }
        static productData addProduct()
        {
            productData p = new productData();
            Console.Write("Enter Product Name : ");
            p.pName = Console.ReadLine();
            Console.Write("Enter Product Category : ");
            p.pCateg = Console.ReadLine();
            Console.Write("Enter Product Price : ");
            p.pPrice = float.Parse(Console.ReadLine());
            Console.Write("Enter Product Quantity : ");
            p.pQuan = float.Parse(Console.ReadLine());
            Console.Write("Enter Product Minimum Quantity: ");
            p.miniQuan = float.Parse(Console.ReadLine());
            return p;
        }
        static void viewProduct(List<productData> p)
        {
            Console.WriteLine("Name\t\t\tCatg\t\t\tPrice\t\t\tQuantity");
            Console.WriteLine("----\t\t\t----\t\t\t-----\t\t\t--------");
            foreach (var i in p)
            {
                Console.WriteLine(i.pName + "\t\t\t" + i.pCateg +"\t\t\t" + i.pPrice +"\t\t\t" + i.pQuan);
            }
        }
        static int Largest(List<productData> p, int s)
        {
            float largest = -1;
            int idx = 0;
            for (int i = s; i < p.Count; i++)
            {
                if(largest < p[i].pPrice)
                {
                    largest = p[i].pPrice;
                    idx = i;
                }
            }
            return idx;
        }
        static void highestPricedProduct(List<productData> p)
        {
            int largest_idx;
            string temp1, temp2;
            float temp3;
            float temp4, temp5;
            for (int i = 0; i < p.Count; i++)
            {
                largest_idx = Largest(p,i);
                temp1 = p[largest_idx].pName;
                p[largest_idx].pName = p[i].pName;
                p[i].pName = temp1;

                temp2 = p[largest_idx].pCateg;
                p[largest_idx].pCateg = p[i].pCateg;
                p[i].pCateg = temp2;

                temp3 = p[largest_idx].pPrice;
                p[largest_idx].pPrice = p[i].pPrice;
                p[i].pPrice = temp3;

                temp4 = p[largest_idx].pQuan;
                p[largest_idx].pQuan = p[i].pQuan;
                p[i].pQuan = temp4;

                temp5 = p[largest_idx].miniQuan;
                p[largest_idx].miniQuan = p[i].miniQuan;
                p[i].miniQuan = temp5;
            }

            Console.WriteLine("Name : " + p[0].pName);
            Console.WriteLine("Category : " + p[0].pCateg);
            Console.WriteLine("Price : " + p[0].pPrice);
            Console.WriteLine("Quantity : " + p[0].pQuan);
            Console.WriteLine("Minimum Quantity : " + p[0].miniQuan);

        }
        static void addTax(List<productData> p)
        {
            Console.WriteLine("Name\t\t\tCatg\t\t\tPrice\t\t\tSales Tax");
            Console.WriteLine("----\t\t\t----\t\t\t-----\t\t\t---------");
            float tax;
            foreach (var i in p)
            {
                if(i.pCateg == "Grocery")
                {
                    tax = i.pPrice * (10 / 100);
                }
                else if (i.pCateg == "Fruit")
                {
                    tax = i.pPrice * (5 / 100);
                }
                else
                {
                    tax = i.pPrice * (15 / 100);
                }
                i.pPrice = i.pPrice - tax;
                Console.WriteLine(i.pName + "\t\t\t" + i.pCateg + "\t\t\t" + i.pPrice + "\t\t\t" + tax);
            }
        }
    }
}
