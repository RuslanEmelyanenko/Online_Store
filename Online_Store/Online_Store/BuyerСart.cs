using System;
using System.Collections;

namespace Online_Store
{
    public class BuyerСart
    {
        public ArrayList buyerCart { get; set; }

        public BuyerСart()
        {
        }

        public BuyerСart(ArrayList buyerCart)
        {
            this.buyerCart = buyerCart;
        }

        public void BuyerCartDisplayInfo()
        {
            Console.WriteLine("Корзина покупателя: " + buyerCart);
        }
    }
}
