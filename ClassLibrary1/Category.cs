using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Models
{
    public class Category
    {
        public int CategoryID { get; private set; }
        public string CategoryName { get; set; }
        public  string Description {get; set;}
        public byte[] Picture { get; set; }

        public Category() { }
        public Category(int id)
        {
            CategoryID = id;
        }
    }
}
