using Microsoft.Data.SqlClient;
using System.Data;
using Entity;
using Data;

namespace Buisnes
{
    public class ProductBusiness
    {
        private ProductDataAccess dataAccess; 

        public ProductBusiness()
        {
            dataAccess = new ProductDataAccess(); 
        }

        public List<Product> ListProductsByName(string productName)
        {
           
            List<Product> products = dataAccess.GetProductsByName(productName);

            return products;
        }
    }
}