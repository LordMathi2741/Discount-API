using Infraestructure.Models;

namespace Infraestructure
{
    public interface IProductFactory
    {
        public bool Save (Product product, List<Product> products);
        public List<Product> GetAll(List<Product> products);
        public bool Update (Product product, int id);
        public bool Delete (int id);
    }
}