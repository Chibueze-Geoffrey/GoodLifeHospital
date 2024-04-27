namespace GoodLifeHospital.Entities
{
    public class Doctor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public Guid LicenseNumber { get; set; }




    }
}
