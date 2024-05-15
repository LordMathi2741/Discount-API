using Infraestructure.Models;

namespace Infraestructure
{
    public class MemberShipGold : IMemberShipFactory
    {
        public bool Save(Membership memberShip)
        {
            throw new NotImplementedException();
        }

        public List<Membership> GetAll()
        {
            var memberShips = new List<Membership>();
            memberShips.Add(new Membership { Id = 1, FirstName="Mathi", LastName="Jave", Type = "Gold" });
            memberShips.Add(new Membership { Id = 2, FirstName="Gustavo", LastName="Huilca", Type = "Gold" });
            return memberShips;
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
