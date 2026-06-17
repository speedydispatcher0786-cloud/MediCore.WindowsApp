using MediCore.App.Core.Models;
//using MediCore.Core.Models;
using System.Collections.Generic;

namespace MediCore.App.Core.Contracts
{
    public interface IPatientService
    {
        List<Patient> GetAllPatients();

        Patient GetPatientById(int id);

        void AddPatient(Patient patient);

        void UpdatePatient(Patient patient);

        void DeletePatient(int id);
    }
}