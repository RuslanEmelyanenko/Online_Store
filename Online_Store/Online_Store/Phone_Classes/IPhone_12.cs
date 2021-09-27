using System;
namespace Online_Store
{
    public class IPhone_12 : Phone
    {
        public IPhone_12()
        {
        }

        public IPhone_12(PhoneModel Model, int PhoneMemory, PhoneСolor Color, string PhoneVendorCode, double Price)
            : base(Model, PhoneMemory, Color, PhoneVendorCode, Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
