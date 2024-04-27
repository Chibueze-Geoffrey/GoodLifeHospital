using System.ComponentModel.DataAnnotations.Schema;

namespace GoodLifeHospital.Entities
{
    public class Appointment : BaseEntity
    {
        [ForeignKey("PatientId")]
        public Patient? patient {  get; set; }
        public string  PatientId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor? doctor { get; set; }
        public string DoctorId {  get; set; }
        [ForeignKey("NurseId")]
        public Nurse? nurse {  get; set; }
        public string NurseId { get; set; }

        public DateTime DateVisited {  get; set; }
        public string Reason {  get; set; }

    }
}
