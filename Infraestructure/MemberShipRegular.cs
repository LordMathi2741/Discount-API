using Infraestructure.Models;

namespace Infraestructure
{
    public class MemberShipRegular : IMemberShipFactory
    {
        public bool Save(Membership memberShip)
        {
            throw new NotImplementedException();
        }

        public List<Membership> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Membership memberShip, int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}