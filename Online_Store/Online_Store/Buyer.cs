using System;
using System.Collections;

namespace Online_Store
{
    public class Buyer : IRepository
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

        // информация о всех товарах в корзине (реализован через интерфейс)
        public void DisplayinfoAllItemFromCollection(ICollection collection)
        {
            foreach (var phone in collection)
            {
                Console.WriteLine(phone.ToString());
            }
        }
    }
}

