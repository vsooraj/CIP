using System.Collections.Generic;

namespace CIP.HIS.Models
{
    public interface IAddressRepository
    {
        IList<Address> Addresses { get; }
    }
}
