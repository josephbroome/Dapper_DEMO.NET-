using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_DEMO.NET_
{
    internal class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public void CreateProduct(string name, double price, int categoryID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM products");
        }


        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
    }
}
