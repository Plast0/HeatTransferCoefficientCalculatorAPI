using AutoMapper;
using CalculatorAPI.Entity;
using CalculatorAPI.Models;

namespace CalculatorAPI
{
    public class CalculatorMappingProfile : Profile
    {
        public CalculatorMappingProfile() {
            CreateMap<User, UserDto>();
            CreateMap<Envelope, EnvelopeDto>();

            CreateMap<Material, MaterialDto>();

            CreateMap<CreateMaterialDto, Material>();

            CreateMap<CreateEnvelopeDto, Envelope>();
        }
    }
}
