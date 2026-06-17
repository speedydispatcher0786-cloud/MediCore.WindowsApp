using MediCore.App.Core.Contracts;
using MediCore.App.Core.Models;
//using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MediCore.App.Services
{
    public class DBAppointmentService : IAppointmentService
    {
        private readonly string _connectionString;

        public DBAppointmentService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Appointment";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Appointment appointment = new Appointment();

                    appointment.Id = Convert.ToInt32(reader["Id"]);
                    appointment.PatientName = reader["PatientName"].ToString();
                    appointment.DoctorName = reader["DoctorName"].ToString();
                    appointment.AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    appointment.Time = reader["Time"].ToString();
                    appointment.Status = reader["Status"].ToString();

                    appointments.Add(appointment);
                }
            }

            return appointments;
        }

        public Appointment GetAppointmentById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Appointment WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Appointment appointment = new Appointment();

                    appointment.Id = Convert.ToInt32(reader["Id"]);
                    appointment.PatientName = reader["PatientName"].ToString();
                    appointment.DoctorName = reader["DoctorName"].ToString();
                    appointment.AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    appointment.Time = reader["Time"].ToString();
                    appointment.Status = reader["Status"].ToString();

                    return appointment;
                }
            }

            return null;
        }

        public void AddAppointment(Appointment appointment)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query =
                    "INSERT INTO Appointment(PatientName, DoctorName, AppointmentDate, Time, Status) " +
                    "VALUES(@PatientName, @DoctorName, @AppointmentDate, @Time, @Status)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PatientName", appointment.PatientName);
                cmd.Parameters.AddWithValue("@DoctorName", appointment.DoctorName);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@Time", appointment.Time);
                cmd.Parameters.AddWithValue("@Status", appointment.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query =
                    "UPDATE Appointment SET " +
                    "PatientName=@PatientName, " +
                    "DoctorName=@DoctorName, " +
                    "AppointmentDate=@AppointmentDate, " +
                    "Time=@Time, " +
                    "Status=@Status " +
                    "WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", appointment.Id);
                cmd.Parameters.AddWithValue("@PatientName", appointment.PatientName);
                cmd.Parameters.AddWithValue("@DoctorName", appointment.DoctorName);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@Time", appointment.Time);
                cmd.Parameters.AddWithValue("@Status", appointment.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAppointment(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Appointment WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}