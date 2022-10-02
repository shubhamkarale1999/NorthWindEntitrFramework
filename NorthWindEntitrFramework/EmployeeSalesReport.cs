using NorthWindEntitrFramework;
using System;

namespace NorthWindEntiteFramework
{
    internal class EmployeeSalesReport
    {
        internal static void Execute()
        {
            using (var db = new NorthwindEntities())
            {

                Console.WriteLine("Enter from date");
                try
                {

                    DateTime @FROM_DATE = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter to date");

                    DateTime @TO_DATE = DateTime.Parse(Console.ReadLine());
                    var emplo = db.usp_EmployeeSalesReport(@FROM_DATE, @TO_DATE);
                    int cnt = 0;
                    foreach (var emp in emplo)
                    {
                        Console.WriteLine($"FIRSTNAME :{emp.Empid} \n LASTNAME :{emp.OrderId} \n ORDERID :{emp.TotalCount} \n ----------------------------------");

                        cnt++;
                    }
                    Console.ReadLine();
                }
                catch
                {
                    LoginPage.Execute();
                }
            }
        }
    }
}