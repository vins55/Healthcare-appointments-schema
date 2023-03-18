namespace Healthcare_appointments_schema.Entities
{
    public class Appointments
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Name { get; set; }
        public Patients Patients { get; set; }
        public Doctors Doctors { get; set; }
    }
}
