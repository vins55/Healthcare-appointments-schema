namespace Healthcare_appointments_schema.Entities
{
    public class Diagnoses
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public string Medicines { get; set; }
        public string Recipes { get; set; }
        public List<Patients> Patients { get; set; }

    }
}
