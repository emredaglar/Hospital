namespace Hospital.Patient.Dtos.PatientChildDto
{
    public class CreatePatientChildDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string ParentNameSurname { get; set; }
    }
}
