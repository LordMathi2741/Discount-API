using Infraestructure.Models;

namespace Infraestructure
{
    public class ElectronicProduct : IProductFactory
    {
        public bool Save(Product product, List<Product> products)
        {
            if (product.Type.ToLower() == "electronic")
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