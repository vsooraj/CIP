using System.Collections.Generic;

namespace CIP.HIS.Models
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> Read();

        void Create(Patient patient);
    }
}
