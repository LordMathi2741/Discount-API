using Infraestructure.Models;

namespace _2._Domain;

public interface IDiscountDomain
{
    Boolean CheckDiscount(Product product, Membership membership);
    void ApplyDiscount(Product product, Membership membership);
    
}