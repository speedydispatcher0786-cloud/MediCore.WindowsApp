using MediCore.App.Core.Models;
//using MediCore.Core.Models;
using System.Collections.Generic;

namespace MediCore.App.Core.Contracts
{
    public interface IAppointmentService
    {
        List<Appointment> GetAllAppointments();

        Appointment GetAppointmentById(int id);

        void AddAppointment(Appointment appointment);

        void UpdateAppointment(Appointment appointment);

        void DeleteAppointment(int id);
    }
}