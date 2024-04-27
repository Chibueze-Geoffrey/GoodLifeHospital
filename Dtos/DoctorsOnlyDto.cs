namespace GoodLifeHospital.Dtos
{
    public class DoctorsOnlyDto
    {
        public string Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public Guid LicenseNumber { get; set; } = Guid.NewGuid();
    }
}
