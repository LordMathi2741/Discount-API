using Infraestructure.Models;

namespace Infraestructure
{
    public class BookProduct : IProductFactory
    {
        public bool Save(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Book 1", Description = "Book", Price = 100, Type = "Book" });
            products.Add(new Product { Id = 2, Name = "Book 2", Description = "Book", Price = 100, Type = "Book" });
            return products;
        }

        public bool Update(Product product, int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}