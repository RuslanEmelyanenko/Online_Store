using System;
using System.Collections;

namespace Online_Store
{
    public class ServiceMethods : IService
    {
        public BuyerСart Сart { get; set; }

        public ServiceMethods()
        {
        }

        public ServiceMethods(BuyerСart Сart)
        {
            this.Сart = Сart;
        }

        public void DisplayinfoAllItemFromCollection(ICollection collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }

        // Total sum items
        public double GetSumAllItemFromCollection(ICollection collection)
        {
            double result = 0;

            foreach (Phone phone in collection)
            {
                result += phone.Price;
            }

            return result;
        }

        // Sorting method by price ... 
   
    }
}