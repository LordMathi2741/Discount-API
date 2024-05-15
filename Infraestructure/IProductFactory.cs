using Infraestructure.Models;

namespace Infraestructure
{
    public interface IProductFactory
    {
        public bool Save (Product product);
        public List<Product> GetAll ();
        public bool Update (Product product, int id);
        public bool Delete (int id);
    }
}