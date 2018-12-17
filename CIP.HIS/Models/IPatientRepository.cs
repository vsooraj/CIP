using System.Collections.Generic;

namespace CIP.HIS.Models
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> Patients { get; }
    }
}
