using System.Collections.Generic;

namespace CIP.HIS.Models
{
    public class MockContactRepository : IContactRepository
    {

        public IList<Contact> Contacts
        {
            get
            {
                return new List<Contact>
                {
                    new Contact{Id = 1, Relationship = "Frined", Name = "Noyal", GivenName = "Noyal Vincy", Phone = "9961598190", Mobile = "9961598190", Email = "NoyalVincy@gmail.com", Gender = "Male", Organization = "Cabot Solutions"}

                };
            }
        }
    }
}
