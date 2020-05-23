using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automapper.FoundationLayer
{
    class ProductDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  ProductPrice ProductPrice { get; set; }
        public ProductInventory ProductInventory { get; set; }
    }

    class ProductPrice
    {
        public double Price { get; set; }
    }

    class ProductInventory
    {
        public int StockValue { get; set; }
    }
}
