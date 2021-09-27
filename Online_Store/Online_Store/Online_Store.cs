using System;
using System.Collections.Generic;

namespace Online_Store
{
    public class Online_Store
    {
        public string Name { get; set; }
        public string TimeWorking { get; set; }
        public string PhoneNumber { get; set; }
        public AdresOnlineStore AdresStore { get; set; }
        public List<Phone> ListOfPhones { get; set; }

        public Online_Store()
        {
        }

        public Online_Store(string Name, string TimeWorking, string PhoneNumber,
            AdresOnlineStore AdresStore, List<Phone> ListOfPhones)
        {
            this.Name = Name;
            this.TimeWorking = TimeWorking;
            this.PhoneNumber = PhoneNumber;
            this.AdresStore = AdresStore;
            this.ListOfPhones = ListOfPhones;
        }

        public void Online_StoreDisplayInfo()
        {
            Console.WriteLine("Название магазина: " + Name +
                "/ Режим работы: " + TimeWorking +
                "/ Телефон: " + PhoneNumber);
        }

        public void AdresOnlineStoreDisplayInfo()
        {
            Console.WriteLine("Адрес магазина: " + "Страна: " +
                AdresStore.Country + "/ Город: " + AdresStore.City + "/ Улица: " +
                AdresStore.Street + "/ Почтовый адрес: " + AdresStore.PostalCode);
        }

        public void PhoneDisplayInfo(Phone phone) // Для одного телефона
        {
            Console.WriteLine(phone.ToString());
        }

        public void DisplayInfoAboutAllPhones() // Для всех телефонов
        {
            foreach (Phone phone in ListOfPhones)
            {
                Console.WriteLine(phone.ToString());
            }
        }
    }
}
