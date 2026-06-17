using MediCore.App.Core.Contracts;
using MediCore.App.Core.Models;
//using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MediCore.App.Services
{
    public class DBBillService : IBillingService
    {
        private readonly string _connectionString;

        public DBBillService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Bill> GetAllBills()
        {
            List<Bill> bills = new List<Bill>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Bill";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bill bill = new Bill();

                    bill.Id = Convert.ToInt32(reader["Id"]);
                    bill.PatientName = reader["PatientName"].ToString();
                    bill.Service = reader["Service"].ToString();
                    bill.TotalBill = Convert.ToDecimal(reader["TotalBill"]);
                    bill.Status = reader["Status"].ToString();

                    bills.Add(bill);
                }
            }

            return bills;
        }

        public Bill GetBillById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Bill WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Bill bill = new Bill();

                    bill.Id = Convert.ToInt32(reader["Id"]);
                    bill.PatientName = reader["PatientName"].ToString();
                    bill.Service = reader["Service"].ToString();
                    bill.TotalBill = Convert.ToDecimal(reader["TotalBill"]);
                    bill.Status = reader["Status"].ToString();

                    return bill;
                }
            }

            return null;
        }

        public void AddBill(Bill bill)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query =
                    "INSERT INTO Bill(PatientName, Service, TotalBill, Status) " +
                    "VALUES(@PatientName, @Service, @TotalBill, @Status)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PatientName", bill.PatientName);
                cmd.Parameters.AddWithValue("@Service", bill.Service);
                cmd.Parameters.AddWithValue("@TotalBill", bill.TotalBill);
                cmd.Parameters.AddWithValue("@Status", bill.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateBill(Bill bill)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query =
                    "UPDATE Bill SET " +
                    "PatientName=@PatientName, " +
                    "Service=@Service, " +
                    "TotalBill=@TotalBill, " +
                    "Status=@Status " +
                    "WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", bill.Id);
                cmd.Parameters.AddWithValue("@PatientName", bill.PatientName);
                cmd.Parameters.AddWithValue("@Service", bill.Service);
                cmd.Parameters.AddWithValue("@TotalBill", bill.TotalBill);
                cmd.Parameters.AddWithValue("@Status", bill.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteBill(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Bill WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}