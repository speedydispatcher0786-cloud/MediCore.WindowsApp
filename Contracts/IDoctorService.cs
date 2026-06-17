using MediCore.App.Core.Models;
//using MediCore.Core.Models;
using System.Collections.Generic;

namespace MediCore.App.Core.Contracts
{
    public interface IDoctorService
    {
        List<Doctor> GetAllDoctors();

        Doctor GetDoctorById(int id);

        void AddDoctor(Doctor doctor);

        void UpdateDoctor(Doctor doctor);

        void DeleteDoctor(int id);
    }
}