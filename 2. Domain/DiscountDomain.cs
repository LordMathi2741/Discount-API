using Infraestructure.Models;

namespace _2._Domain;

public class DiscountDomain : IDiscountDomain
{
    public bool CheckDiscount(Product product, Membership membership)
    {
        if (product.Type.ToLower() == "book")
        {
            return false;
        }
        
        else if (membership.Type.ToLower() == "gold" || (product.Type == "electronic" & product.Price > 1000 ))
        {
            return true;
        }

        return false;

    }

    public void ApplyDiscount(Product product, Membership membership)
    {
        double initialPrice = product.Price;
        double discount = 0.0;
        if (CheckDiscount(product, membership))
        {
            if (membership.Type.ToLower() == "gold")
            {
                discount = discount + 0.2;
            }
            
            else if (product.Type == "electronic" & product.Price > 1000)
            {
                discount = discount + 0.1;
            }
            
        }
        
        product.Price = initialPrice - (initialPrice * discount);
    }
}