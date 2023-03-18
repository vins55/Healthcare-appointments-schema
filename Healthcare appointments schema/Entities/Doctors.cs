namespace Healthcare_appointments_schema.Entities
{
    public class Doctors
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Speciality { get; set; }
        public int InsuranceBelt { get; set; }
        public int Passport { get; set; }
        public decimal Salary { get; set; }
        public List<Appointments> Appointments { get; set; }
    }
}
