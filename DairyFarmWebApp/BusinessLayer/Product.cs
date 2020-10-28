using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DairyFarmWebApp.BusinessLayer
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public int CompanyID { get; set; }

        public Company Company { get; set; }
    }
}
