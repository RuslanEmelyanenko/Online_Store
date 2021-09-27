using System;

namespace Online_Store
{
    public class AdresOnlineStore
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

        public AdresOnlineStore()
        {
        }

        public AdresOnlineStore(string Country, string City, string Street, string PostalCode)
        {
            this.Country = Country;
            this.City = City;
            this.Street = Street;
            this.PostalCode = PostalCode;
        }
    }
}

