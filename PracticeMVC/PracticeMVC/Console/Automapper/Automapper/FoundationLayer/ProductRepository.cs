using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automapper.FoundationLayer
{
    class ProductRepository : ProductDetails
    {

        public IEnumerable<ProductDetails> getProducts()
        {
            List<ProductDetails> objProductList = new List<ProductDetails>();
            objProductList.Add(new ProductDetails
            {
                Id = 2,
                Name = "Product 1",
                Description = "Product 1 Description",
                ProductInventory = new ProductInventory { StockValue = 10 },
                ProductPrice = new ProductPrice { Price = 10.0 }
            });

            objProductList.Add(new ProductDetails
            {
                Id = 2,
                Name = "Product 2",
                Description = "Product 2 Description",
                ProductInventory = new ProductInventory { StockValue = 20 },
                ProductPrice = new ProductPrice { Price = 20.0 }
            });
            return objProductList;
        }

        public ProductDetails getProduct()
        {

            return (new ProductDetails
            {
                Id = 2,
                Name = "Product 1",
                Description = "Product 1 Description",
                ProductInventory = new ProductInventory { StockValue = 10 },
                ProductPrice = new ProductPrice { Price = 10.0 }
            });
        }
    }
}
