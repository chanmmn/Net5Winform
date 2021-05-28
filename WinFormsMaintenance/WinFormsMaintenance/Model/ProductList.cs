using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMaintenance.Model
{
    class ProductList
    {
        public List<Products> products = new List<Products>();

        public ProductList()
        {
            products = new List<Products>()
            {
                new Products{ProductID=1, ProductName="Chai"},
                new Products{ProductID=3, ProductName="Aniseed Syrup"},
                new Products{ProductID=2, ProductName="Chang"}
            };
        }

        public List<Products> GetAllProducts()
        {
            return products;
        }
    }
}
