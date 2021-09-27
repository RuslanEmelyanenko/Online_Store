using System;

namespace Online_Store
{
    public class IPhone_12_mini : Phone
    {
        public IPhone_12_mini()
        {
        }

        public IPhone_12_mini(PhoneModel Model, int PhoneMemory, PhoneСolor Color, string PhoneVendorCode, double Price)
            : base(Model, PhoneMemory, Color, PhoneVendorCode, Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
