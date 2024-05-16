using Infraestructure.Models;

namespace Infraestructure
{
    public class BookProduct : IProductFactory
    {
        public bool Save(Product product, List<Product> products)
        {
            if (product.Type.ToLower() == "book")
            {
                products.Add(product);
            }
            return true;
        }

        public List<Product> GetAll(List<Product> products)
        {
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