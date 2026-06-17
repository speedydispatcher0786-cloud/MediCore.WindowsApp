namespace MediCore.App.Core.Models
{
    public class Bill
    {
        public int Id { get; set; }

        public string PatientName { get; set; }

        public string Service { get; set; }

        public decimal TotalBill { get; set; }

        public string Status { get; set; }
    }
}
