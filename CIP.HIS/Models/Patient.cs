using System.Collections.Generic;

namespace CIP.HIS.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GivenName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public bool MultipleBirth { get; set; }
        public bool Deceased { get; set; }
        public bool Active { get; set; }
        public string MaritalStatus { get; set; }
        public string Communication { get; set; }
        public string ManagingOrganization { get; set; }
        public IList<Address> Addresses { get; set; }
        public IList<Contact> Contacts { get; set; }
        public string ImageThumbnailUrl { get; set; }


    }
}
