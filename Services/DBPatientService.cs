using MediCore.App.Core.Models;
//using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MediCore.App.Services
{
    public class DBPatientService
    {
        private readonly string _connectionString;

        public DBPatientService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Patient";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Patient patient = new Patient();

                    patient.Id = Convert.ToInt32(reader["Id"]);
                    patient.Name = reader["Name"].ToString();
                    patient.Age = Convert.ToInt32(reader["Age"]);
                    patient.Gender = reader["Gender"].ToString();
                    patient.Contact = reader["Contact"].ToString();
                    patient.BloodGroup = reader["BloodGroup"].ToString();

                    patients.Add(patient);
                }
            }

            return patients;
        }

        public void AddPatient(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query =
                    "INSERT INTO Patient(Name, Age, Gender, Contact, BloodGroup) " +
                    "VALUES(@Name, @Age, @Gender, @Contact, @BloodGroup)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Age", patient.Age);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Contact", patient.Contact);
                cmd.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);

                cmd.ExecuteNonQuery();
            }
        }

        public Patient GetPatientById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Patient WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Patient patient = new Patient();

                    patient.Id = Convert.ToInt32(reader["Id"]);
                    patient.Name = reader["Name"].ToString();
                    patient.Age = Convert.ToInt32(reader["Age"]);
                    patient.Gender = reader["Gender"].ToString();
                    patient.Contact = reader["Contact"].ToString();
                    patient.BloodGroup = reader["BloodGroup"].ToString();

                    return patient;
                }
            }

            return null;
        }

        public void UpdatePatient(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query =
                    "UPDATE Patient SET " +
                    "Name=@Name, " +
                    "Age=@Age, " +
                    "Gender=@Gender, " +
                    "Contact=@Contact, " +
                    "BloodGroup=@BloodGroup " +
                    "WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", patient.Id);
                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Age", patient.Age);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Contact", patient.Contact);
                cmd.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePatient(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Patient WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
