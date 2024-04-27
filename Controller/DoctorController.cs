using AutoMapper;
using GoodLifeHospital.Dtos;
using GoodLifeHospital.Entities;
using GoodLifeHospital.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoodLifeHospital.Controller
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private IRepository<Doctor> _doctorRepository;
        private IRepository<Patient> _patientRepository;
        private IRepository<Treatment> _treatmentRepository;
        private IMapper _mapper;
        public DoctorController(IRepository<Doctor> doctorRepository, IRepository<Patient> patientRepository,
            IRepository<Treatment> treatmentRepository,IMapper mapper)
        {
            _doctorRepository = doctorRepository ??
                throw new ArgumentNullException(nameof(doctorRepository));
            _patientRepository = patientRepository ??
                throw new ArgumentNullException(nameof(patientRepository));
            _treatmentRepository = treatmentRepository ??
                throw new ArgumentNullException(nameof(treatmentRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public ActionResult<IEnumerable<DoctorsOnlyDto>> GetDoctors()
        {
            var doctorsOnDuty = _doctorRepository.All();
            return Ok(_mapper.Map<IEnumerable<DoctorsOnlyDto>>(doctorsOnDuty));
        }
    }
}
