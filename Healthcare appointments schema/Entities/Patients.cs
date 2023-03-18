namespace Healthcare_appointments_schema.Entities
{
    public class Patients
    {
        public int Id { get; set; }
        public int IdDoctor { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public int InsuranceBelt { get; set; }
        public Appointments Appointments { get; set; }
        public List<Appointments> Appointment { get; set; }
    }
}
