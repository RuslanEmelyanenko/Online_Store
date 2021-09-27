using System;

namespace Online_Store
{
    public class IPhone_12_Pro : Phone
    {
        public IPhone_12_Pro()
        {
        }

        public IPhone_12_Pro(PhoneModel Model, int PhoneMemory, PhoneСolor Color, string PhoneVendorCode, double Price)
            : base(Model, PhoneMemory, Color, PhoneVendorCode, Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
