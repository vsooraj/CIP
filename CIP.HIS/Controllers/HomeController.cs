using CIP.HIS.Models;
using CIP.HIS.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CIP.HIS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPatientRepository _patientRepository;

        public HomeController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Patients = _patientRepository.Patients
            };

            return View();
        }
    }
}
