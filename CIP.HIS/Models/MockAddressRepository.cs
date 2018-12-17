using System.Collections.Generic;

namespace CIP.HIS.Models
{
    public class MockAddressRepository : IAddressRepository
    {

        public IList<Address> Addresses
        {
            get
            {
                return new List<Address>
                {
                    new Address{Id=2,Address1="Lulu Cyber Tower",Address2="Tower 1",City="Kochi",Country="India",State="Kerala",Zip="682028"}

                };
            }
        }
    }
}
