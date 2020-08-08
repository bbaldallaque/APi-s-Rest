using System;
using System.Collections.Generic;
using System.Text;

namespace Shoping.Model.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public double SalePrice { get; set; }

        public double PurchasePrice { get; set; }

        public int Stock { get; set; }

    }
}
