using CIP.HIS.Models;
using System.Collections.Generic;

namespace CIP.HIS.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Patient> Patients { get; set; }
    }
}
