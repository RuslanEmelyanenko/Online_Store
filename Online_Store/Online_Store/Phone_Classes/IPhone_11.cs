using System;

namespace Online_Store
{
    public class IPhone_11 : Phone
    {
        public IPhone_11()
        {
        }

        public IPhone_11(PhoneModel Model, int PhoneMemory, PhoneСolor Color, string PhoneVendorCode, double Price)
            : base(Model, PhoneMemory, Color, PhoneVendorCode, Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
