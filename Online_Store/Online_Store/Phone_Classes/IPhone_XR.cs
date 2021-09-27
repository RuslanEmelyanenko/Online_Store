using System;

namespace Online_Store
{
    public class IPhone_XR : Phone
    {
        public IPhone_XR()
        {
        }

        public IPhone_XR(PhoneModel Model, int PhoneMemory, PhoneСolor Color, string PhoneVendorCode, double Price)
            : base(Model, PhoneMemory, Color, PhoneVendorCode, Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
