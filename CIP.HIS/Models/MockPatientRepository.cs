using System.Collections.Generic;

namespace CIP.HIS.Models
{
    public class MockPatientRepository : IPatientRepository
    {
        private IAddressRepository _addressRepository;
        private IContactRepository _contactRepository;

        public MockPatientRepository(IAddressRepository addressRepository, IContactRepository contactRepository)
        {
            _addressRepository = addressRepository;
            _contactRepository = contactRepository;

        }
        public IEnumerable<Patient> Patients
        {
            get
            {
                return new List<Patient>
                {
                    new Patient {
                        Id=1,
                        Name="John",
                        GivenName="Doe",
                        Phone="9961598189",
                        Mobile="9961598189",
                        Email="JohnDoe@outlook.com ",
                        Gender="Male",
                        BirthDate="31-05-2000",
                        MultipleBirth=false,
                        Deceased=true,
                        Active=true,
                        MaritalStatus="Married",
                        Communication="India",
                        ManagingOrganization="Cabot Solutions",
                        ImageThumbnailUrl="/Images/headshot.jpg",
                        Addresses=_addressRepository.Addresses,
                        Contacts=_contactRepository.Contacts
                    },
                     new Patient {
                        Id=2,
                        Name="Jai",
                        GivenName="Doe",
                        Phone="9961598189",
                        Mobile="9961598189",
                        Email="JaiDoe@outlook.com ",
                        Gender="Male",
                        BirthDate="31-05-2000",
                        MultipleBirth=false,
                        Deceased=true,
                        Active=true,
                        MaritalStatus="Bachelor",
                        Communication="India",
                        ManagingOrganization="Cabot Solutions",
                        ImageThumbnailUrl="/Images/headshot.jpg",
                      Addresses=_addressRepository.Addresses,
                        Contacts=_contactRepository.Contacts
                    },
                      new Patient {
                        Id=3,
                        Name="Jim",
                        GivenName="Doe",
                        Phone="9961598189",
                        Mobile="9961598189",
                        Email="JimDoe@outlook.com ",
                        Gender="Female",
                        BirthDate="31-05-2000",
                        MultipleBirth=false,
                        Deceased=true,
                        Active=true,
                        MaritalStatus="Bachelor",
                        Communication="India",
                        ManagingOrganization="Cabot Solutions",
                        ImageThumbnailUrl="/Images/headshot.jpg",
                       Addresses=_addressRepository.Addresses,
                        Contacts=_contactRepository.Contacts
                    }
                };
            }
        }

        public void Create(Patient patient)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Patient> Read()
        {
            return Patients;
        }
    }
}
