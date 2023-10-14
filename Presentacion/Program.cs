using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del producto a buscar: ");
            string productName = Console.ReadLine();

            ProductDataAccess productDataAccess = new ProductDataAccess();
            List<Product> products = productDataAccess.GetProductsByName(productName);

            foreach (Product product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}, Nombre: {product.Name}, Precio: {product.Price:C}, Stock: {product.Stock}");
            }
        }
    }
}
