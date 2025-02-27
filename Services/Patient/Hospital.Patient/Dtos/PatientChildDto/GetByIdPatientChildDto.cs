namespace Hospital.Patient.Dtos.PatientChildDto
{
    public class GetByIdPatientChildDto
    {
        public string PatientChildId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string ParentNameSurname { get; set; }
    }
}
