using AutoMapper;

namespace GoodLifeHospital.Profiles
{
    public class DoctorProfile: Profile
    {
        public DoctorProfile()
        {

            CreateMap<Entities.Doctor, Dtos.DoctorsOnlyDto>();
            CreateMap<Entities.Doctor, Dtos.DoctorDto>();
        }
    }
}
