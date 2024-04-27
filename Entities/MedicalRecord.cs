using System.ComponentModel.DataAnnotations.Schema;

namespace GoodLifeHospital.Entities
{
    public class MedicalRecord : BaseEntity
    {
        [ForeignKey("PatientId")]
        public Patient? patient { get; set; }
        public string PatientId { get; set; }
        public string Diagnosis {  get; set; }
        public string Treatment {  get; set; }
        public string Prescriptions {  get; set; }

    }
}
