using System;

namespace NorthWindEntiteFramework
{
    internal class LoginPage
    {
        internal static void Execute()
        {
            Console.WriteLine("Please Choose Correst Option");
            Console.WriteLine("1.Employee Sales report");
            Console.WriteLine("2.Weekly sales report");
            Console.WriteLine("3.Product wise monthly report");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {

                        EmployeeSalesReport.Execute();
                    }
                    break;
                case 2:
                    {
                        WeeklysalesReport.Execute();
                    }
                    break;
                case 3:
                    {
                        ProductSalesReport.Execute();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Please Choose Correct Option");
                    }
                    break;
            }

        }
    }
}