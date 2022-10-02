using NorthWindEntitrFramework;
using System;

namespace NorthWindEntiteFramework
{
    internal class ProductSalesReport
    {
        internal static void Execute()
        {
            using (var db = new NorthwindEntities())
            {

                Console.WriteLine("Please Enter Product Name");
                string ProductName = Console.ReadLine();
                Console.WriteLine("Please Enter Month");
                string Month = Console.ReadLine();
                Console.WriteLine("Please Enetr Year");
                int year = int.Parse(Console.ReadLine());

                var prod = db.usp_SalesByMonth(ProductName, Month, year);
                foreach (var item in prod)
                {
                    Console.WriteLine("Product Name     {0}", item.ProductName);
                    Console.WriteLine("Month Name       {0}", item.month);
                    Console.WriteLine("Total Price      {0}", item.TatalOrderPrice);
                }
                Console.ReadLine();
            }
        }
    }
}