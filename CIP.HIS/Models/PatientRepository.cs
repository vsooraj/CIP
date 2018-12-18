using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CIP.HIS.Models
{
    public class PatientRepository: IPatientRepository
    {
        private IAddressRepository _addressRepository;
        private IContactRepository _contactRepository;
        private IConfiguration _configuration;

        public PatientRepository(IAddressRepository addressRepository, IContactRepository contactRepository, IConfiguration configuration)
        {
            _addressRepository = addressRepository;
            _contactRepository = contactRepository;
            _configuration = configuration;

        }

        public IEnumerable<Patient> Read()
        {
            IEnumerable<Patient> queryResult;

            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                queryResult = connection.Query<Patient>("SELECT * FROM tblPatient");
                connection.Close();
            }
            return queryResult.ToList();

        }

        public void Create(Patient patient)
        {

            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                SqlCommand cmd = new SqlCommand("insert into tblPatient(Name,GivenName,Phone,Email) values ('" + patient.Name + "','" + patient.GivenName + "','" + patient.Phone + "','" + patient.Email + "')", connection);
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
