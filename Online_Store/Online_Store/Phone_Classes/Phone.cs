using System;

namespace Online_Store
{
    public class Phone
    {
        public PhoneModel Model { get; set; }
        public int PhoneMemory { get; set; }
        public PhoneСolor Color { get; set; }
        public string PhoneVendorCode { get; set; }
        public double Price { get; set; }

        public Phone()
        {
        }

        public Phone(PhoneModel Model, int PhoneMemory, PhoneСolor Color, string PhoneVendorCode, double Price)
        {
            this.Model = Model;
            this.PhoneMemory = PhoneMemory;
            this.Color = Color;
            this.PhoneVendorCode = PhoneVendorCode;
            this.Price = Price;
        }

        public override string ToString()
        {
            return "Модель телефона: " + Model +
                " / Память : " + PhoneMemory + " ГБ" +
                " / Цвет: " + Color +
                " / Артикул: " + PhoneVendorCode +
                " / Цена: " + Price + " BYN";
        }
    }
}
