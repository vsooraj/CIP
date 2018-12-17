using System.Collections.Generic;

namespace CIP.HIS.Models
{
    public interface IContactRepository
    {
        IList<Contact> Contacts { get; }
    }
}
