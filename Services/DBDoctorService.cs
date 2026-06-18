using MediCore.App.Core.Models;
//using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MediCore.App.Services
{
    public class DBDoctorService
    {
        private readonly string _connectionString;

        public DBDoctorService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            /// Database service responsible for doctor management operations.

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Doctor";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Doctor doctor = new Doctor();

                    doctor.Id = Convert.ToInt32(reader["Id"]);
                    doctor.Name = reader["Name"].ToString();
                    doctor.Specialization = reader["Specialization"].ToString();
                    doctor.Contact = reader["Contact"].ToString();
                    doctor.AvailableDays = reader["AvailableDays"].ToString();

                    doctors.Add(doctor);
                }
            }

            return doctors;
        }

        public void AddDoctor(Doctor doctor)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query =
                    "INSERT INTO Doctor(Name, Specialization, Contact, AvailableDays) " +
                    "VALUES(@Name, @Specialization, @Contact, @AvailableDays)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", doctor.Name);
                cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                cmd.Parameters.AddWithValue("@Contact", doctor.Contact);
                cmd.Parameters.AddWithValue("@AvailableDays", doctor.AvailableDays);

                cmd.ExecuteNonQuery();
            }
        }

        public Doctor GetDoctorById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Doctor WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Doctor doctor = new Doctor();

                    doctor.Id = Convert.ToInt32(reader["Id"]);
                    doctor.Name = reader["Name"].ToString();
                    doctor.Specialization = reader["Specialization"].ToString();
                    doctor.Contact = reader["Contact"].ToString();
                    doctor.AvailableDays = reader["AvailableDays"].ToString();

                    return doctor;
                }
            }

            return null;
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query =
                    "UPDATE Doctor SET " +
                    "Name=@Name, " +
                    "Specialization=@Specialization, " +
                    "Contact=@Contact, " +
                    "AvailableDays=@AvailableDays " +
                    "WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", doctor.Id);
                cmd.Parameters.AddWithValue("@Name", doctor.Name);
                cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                cmd.Parameters.AddWithValue("@Contact", doctor.Contact);
                cmd.Parameters.AddWithValue("@AvailableDays", doctor.AvailableDays);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDoctor(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Doctor WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
