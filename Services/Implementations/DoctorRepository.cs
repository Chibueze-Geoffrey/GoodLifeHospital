using GoodLifeHospital.DatabaseContext;
using GoodLifeHospital.Entities;

namespace GoodLifeHospital.Services.Implementations
{
    public class DoctorRepository : GenericRepository<Doctor>
    {
        public DoctorRepository(GoodLifeContext context) : base(context)
        {
        }
        public override Doctor Update(Doctor entity)
        {
            Doctor toUpdate = Get(entity.Id);
            toUpdate.FirstName = entity.FirstName;
            toUpdate.LastName = entity.LastName;
            toUpdate.LicenseNumber = entity.LicenseNumber;
            return base.Update(entity);
        }
    }
}
