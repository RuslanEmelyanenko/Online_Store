using System;

namespace Online_Store
{
    public class IPhone_SE : Phone
    {
        public IPhone_SE()
        {
        }

        public IPhone_SE(PhoneModel Model, int PhoneMemory, PhoneСolor Color, string PhoneVendorCode, double Price)
            : base(Model, PhoneMemory, Color, PhoneVendorCode, Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
