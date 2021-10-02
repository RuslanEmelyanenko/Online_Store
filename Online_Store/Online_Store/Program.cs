using System;
using System.Collections;
using System.Collections.Generic;

namespace Online_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class_Phone
            var iPhone_XR_MH6M3RM = new IPhone_XR(PhoneModel.iPhone_XR, 64, PhoneСolor.Black, "MH6M3RM/A", 1899.0);
            var iPhone_XR_MH6N3RM = new IPhone_XR(PhoneModel.iPhone_XR, 64, PhoneСolor.White, "MH6N3RM/A", 1899.0);
            var iPhone_XR_MH7L3RM = new IPhone_XR(PhoneModel.iPhone_XR, 128, PhoneСolor.Gold, "MH7L3RM/A", 2099.0);

            var iPhone_11_MH7L3RN = new IPhone_11(PhoneModel.iPhone_11, 64, PhoneСolor.Green, "MH7L3RN/A", 1999.0);
            var iPhone_11_MR7L3RN = new IPhone_11(PhoneModel.iPhone_11, 64, PhoneСolor.Red, "MR7L3RN/A", 1999.0);
            var iPhone_11_MR7L3SN = new IPhone_11(PhoneModel.iPhone_11, 128, PhoneСolor.Blu, "MR7L3SN/A", 2199.0);
            var iPhone_11_MD7L3SN = new IPhone_11(PhoneModel.iPhone_11, 128, PhoneСolor.Pink_Gold, "MD7L3SN/A", 2199.0);

            var iPhone_SE_MHGQ3RM = new IPhone_SE(PhoneModel.iPhone_SE, 64, PhoneСolor.Silver, "MHGQ3RM/A", 1299.0);
            var iPhone_SE_MRGQ3RN = new IPhone_SE(PhoneModel.iPhone_SE, 128, PhoneСolor.Space_Gray, "MRGQ3RN/A", 1499.0);
            var iPhone_SE_MNGQ3RN = new IPhone_SE(PhoneModel.iPhone_SE, 256, PhoneСolor.Black, "MNGQ3RN/A", 2099.0);

            var iPhone_12_mini_MGDY3RM = new IPhone_12_mini(PhoneModel.iPhone_12_mini, 64, PhoneСolor.Green, "MGDY3RM/A", 2299.0);
            var iPhone_12_mini_MRDY3RM = new IPhone_12_mini(PhoneModel.iPhone_12_mini, 128, PhoneСolor.White, "MRDY3RM/A", 2499.0);
            var iPhone_12_mini_MSDY3RM = new IPhone_12_mini(PhoneModel.iPhone_12_mini, 256, PhoneСolor.Gold, "MSDY3RM/A", 3199.0);

            var iPhone_12_Pro_Max_MGD93RM = new IPhone_12_Pro_Max(PhoneModel.iPhone_12_Pro_Max, 128, PhoneСolor.White, "MGD93RM/A", 4199.0);

            var iPhone_12_Pro_MGMK3RM = new IPhone_12_Pro(PhoneModel.iPhone_12_Pro, 128, PhoneСolor.Space_Gray, "MGMK3RM/A", 3799.0);

            var iPhone_12_MGJE3RM = new IPhone_12(PhoneModel.iPhone_12, 128, PhoneСolor.Blu, "MGJE3RM/A", 2899.0);

            List<Phone> phones = new List<Phone>();

            phones.Add(iPhone_XR_MH6M3RM);
            phones.Add(iPhone_XR_MH6N3RM);
            phones.Add(iPhone_XR_MH7L3RM);

            phones.Add(iPhone_11_MH7L3RN);
            phones.Add(iPhone_11_MR7L3RN);
            phones.Add(iPhone_11_MR7L3SN);
            phones.Add(iPhone_11_MD7L3SN);

            phones.Add(iPhone_SE_MHGQ3RM);
            phones.Add(iPhone_SE_MRGQ3RN);
            phones.Add(iPhone_SE_MNGQ3RN);

            phones.Add(iPhone_12_mini_MGDY3RM);
            phones.Add(iPhone_12_mini_MRDY3RM);
            phones.Add(iPhone_12_mini_MSDY3RM);

            phones.Add(iPhone_12_Pro_Max_MGD93RM);

            phones.Add(iPhone_12_Pro_MGMK3RM);

            phones.Add(iPhone_12_MGJE3RM);

            //phones.Sort(); // Sort items by price from Min to Max
            //phones.Reverse(); // Sort items by price from Max to Min

            Online_Store store = new Online_Store("Mobi-Stor ", "Пн.- Сб с 9-00 до 21:00 ", "+375 (44) 0000000 ",
                new AdresOnlineStore("Беларусь ", "Минск ", "пр-т Партизанский 109Б", "220019"), phones);
            store.Online_StoreDisplayInfo();
            Console.WriteLine(new String('-', 110));

            store.AdresOnlineStoreDisplayInfo();
            Console.WriteLine(new String('-', 110));

            Console.WriteLine("Выберите метод отоброжения списка телефонов: " +
                "\n\n1. Стандартный;" +
                "\n2. По цене, от Мin до Мax" +
                "\n3. По цене, от Max до Мin");

            Console.Write("\nВведите метод: ");

            int method = int.Parse(Console.ReadLine());
            Console.WriteLine(new String('-', 110));

            if (method == 1)
            {
                store.DisplayinfoAllItemFromCollection(phones);
                
            }
            else if (method == 2)
            {
                phones.Sort(); // Sort items by price from Min to Max

                foreach (Phone phone in phones)
                {
                    Console.WriteLine(phone);
                }
            }
            else
            {
                phones.Sort(); // Sort items by price from Min to Max
                phones.Reverse(); // Sort items by price from Max to Min

                foreach (Phone phone in phones)
                {
                    Console.WriteLine(phone);
                }
            }
            Console.WriteLine(new String('-', 110));

            // Class Buyer / (add items the buyer cart)
            ArrayList buyerСart = new ArrayList();

            buyerСart.Add(iPhone_12_Pro_Max_MGD93RM);
            buyerСart.Add(iPhone_SE_MNGQ3RN);
            buyerСart.Add(iPhone_XR_MH6M3RM);

            //buyerСart.Clear(); // Удалить все товары из корзины
            //buyerСart.Remove(iPhone_12_Pro_Max_MGD93RM); // Удаление с карзины определенного товара

            Buyer buyer = new Buyer("Ruslan", "+375 (33) 3500000", true, new BuyerСart(buyerСart));

            buyer.BuyerDisplayInfo();
            Console.WriteLine(new String('-', 34));

            Console.WriteLine("Корзина: \n");
            buyer.DisplayinfoAllItemFromCollection(buyerСart);

            // Class service / The total cost of all items in the buyer cart
            ServiceMethods serviceMethods = new ServiceMethods(new BuyerСart(buyerСart));
            
            serviceMethods.GetSumAllItemFromCollection(buyerСart);

            Console.WriteLine($"\nИтоговая стоимость за {buyerСart.Count} товар(а)" +
                $" состовляет: " + serviceMethods.GetSumAllItemFromCollection(buyerСart) + " BYN");
        }
    }
}
