using Infraestructure.Models;

namespace Infraestructure
{
    public class ElectronicProduct : IProductFactory
    {
        public bool Save(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
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