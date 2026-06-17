namespace MediCore.App.Core.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Specialization { get; set; }

        public string Contact { get; set; }

        public string AvailableDays { get; set; }
    }
}