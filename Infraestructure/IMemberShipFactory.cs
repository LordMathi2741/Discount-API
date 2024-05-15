using Infraestructure.Models;

namespace Infraestructure
{
    public interface IMemberShipFactory
    {
        public bool Save(Membership memberShip);
        public List<Membership> GetAll();
        public bool Update(Membership memberShip, int id);
        public bool Delete(int id);
        
    
    }
}
