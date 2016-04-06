using NW.Models;
using NW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NW.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

            Repository r = new Repository(connStr);
            var categories = r.GetAllCategories();
            foreach (Category c in categories)
            {
                Console.WriteLine(c.CategoryName);
            }
            
            Console.ReadKey();
        }
    }
}
