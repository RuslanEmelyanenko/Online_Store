using System;

namespace Online_Store
{
    public class Buyer
    {
        public string BuyerName { get; set; }
        public string BuyerPhoneNumber { get; set; }
        public bool СardCurrency { get; set; }
        public BuyerСart Сart { get; set; }

        public Buyer()
        {
        }

        public Buyer(string BuyerName, string BuyerPhoneNumber, bool СardCurrency, BuyerСart Сart)
        {
            this.BuyerName = BuyerName;
            this.BuyerPhoneNumber = BuyerPhoneNumber;
            this.СardCurrency = СardCurrency;
            this.Сart = Сart;
        }

        public void BuyerDisplayInfo()
        {
            Console.WriteLine($"Имя покупателя: {BuyerName} \nНомер телефона: {BuyerPhoneNumber}");
        }

        // информация о одном товаре в корзине
        public void BuyerСartDisplayInfo()
        {
            Console.WriteLine("Корзина покупателя: \n");
            Console.WriteLine(((Phone)Сart.buyerCart[0]).ToString());
        }

        // информация о всех товарах в корзине
        public void DisplayInfoAboutAllBuyerCart()
        {
            Console.WriteLine("Корзина покупателя: \n");

            foreach (Phone phone in Сart.buyerCart)
            {
                Console.WriteLine(phone.ToString());
            }
        }
    }
}

