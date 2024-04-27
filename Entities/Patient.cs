namespace GoodLifeHospital.Entities
{
    public class Patient : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
    }
}
